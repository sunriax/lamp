using Microsoft.Extensions.Configuration;
using RaGae.App.Lamp.Domain.Model;
using RaGae.App.Lamp.Forms.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RaGae.App.Lamp.Forms
{
    public partial class FormMain : Form
    {
        private Packet packet;

        public FormMain()
        {
            this.InitializeComponent();

            Program.Timer.Tick += Timer_Tick;
            Program.SerialService.DataHandler += this.SerialService_Data;
            Program.SerialService.ErrorHandler += this.SerialService_Error;
            Program.NotifyIcon.MouseDoubleClick += this.notifyIcon_MouseDoubleClick;
            Program.NotifyIcon.ContextMenuStrip = this.contextMenuStrip;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.ValidateSerialStatus();
            this.checkBoxNotification.Checked = Program.SystemConfig.Notification;
        }

        private void ValidateSerialStatus()
        {
            if (!Program.SerialService.Status)
            {
                this.labelStatus.Text = Resources.StringResource.ConnectionError;
                this.labelStatus.ForeColor = Color.Red;
            }
            else
            {
                this.labelStatus.Text = Resources.StringResource.ConnectionEstablished;
                this.labelStatus.ForeColor = Color.Green;
            }
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e) => this.Close();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Save())
                MessageBox.Show(Resources.StringResource.SettingsSaved, Resources.StringResource.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormConfiguration(packet);
            form.ShowDialog();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormConnection();
            form.ShowDialog();

            this.ValidateSerialStatus();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormMessage();
            form.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update = Program.Configuration.GetSection(nameof(Update)).Get<Update>();

            string test = Path.GetDirectoryName(update.Program);

            using (Process process = new()
            {
                StartInfo = new()
                {
                    FileName = update.Program,
                    Arguments = $"-company \"{update.Company}\" -repository \"{update.Repository}\" -version \"{Assembly.GetExecutingAssembly().GetName().Version}\" -directory \"{Directory.GetCurrentDirectory()}\" -process {Process.GetCurrentProcess().Id}",
                    UseShellExecute = update.Shell,
                    WindowStyle = ProcessWindowStyle.Normal,
                    CreateNoWindow = update.NoWindow,
                    WorkingDirectory = update.Directory
                }
            })
            {
                try
                {
                    process.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.StringResource.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormVersion(packet?.Version);
            form.ShowDialog();
        }

        private void checkBoxNotification_CheckedChanged(object sender, EventArgs e) => Program.SystemConfig.Notification = checkBoxNotification.Checked;

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.ShowInTaskbar = false;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SerialService.DataHandler -= SerialService_Data;
            Program.SerialService.ErrorHandler -= SerialService_Error;
            Program.NotifyIcon.MouseDoubleClick -= notifyIcon_MouseDoubleClick;
        }

        private void SerialService_Data(Packet packet)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.configurationToolStripMenuItem.Enabled = false;
                this.packet = packet;
            });

            if (packet.Config)
                if (this.menuStrip.InvokeRequired)
                    this.menuStrip.Invoke((MethodInvoker)delegate
                    {
                        this.configurationToolStripMenuItem.Enabled = true && Program.SerialService.Status;
                    });


            if (this.tableLayoutPanel.InvokeRequired)
            {
                this.tableLayoutPanel?.Invoke((MethodInvoker)delegate
                {
                    this.tableLayoutPanel.Controls?.Clear();

                    foreach (Led led in packet.Mode)
                    {
                        this.tableLayoutPanel.Controls.Add(new UserControlLevel(led));
                    }
                    this.labelMode.Text = packet.Switch.Gray2Binary().ToString();
                });
            }

            if (packet.Status)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (Program.SystemConfig.Notification)
                    {
                        Program.NotifyIcon.BalloonTipTitle = string.IsNullOrWhiteSpace(Program.SystemConfig.BallonTitle) ? Resources.StringResource.BalloonTipTitle : Program.SystemConfig.BallonTitle;
                        Program.NotifyIcon.BalloonTipText = string.IsNullOrWhiteSpace(Program.SystemConfig.BallonText) ? Resources.StringResource.BalloonTipText : Program.SystemConfig.BallonText;
                        Program.NotifyIcon.ShowBalloonTip(Program.SystemConfig.BallonTime);
                    }
                });
            }
        }

        private void SerialService_Error(Error error) => MessageBox.Show($"{error.Type}: {error.Message}", Resources.StringResource.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void Timer_Tick(object sender, EventArgs e)
        {
            Program.SerialService.Open();
            this.Invoke((MethodInvoker)delegate
            {
                this.ValidateSerialStatus();
            });
        }

    }
}
