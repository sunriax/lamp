using RaGae.App.Lamp.Domain.Model;
using RaGae.App.Lamp.Forms.Extensions;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RaGae.App.Lamp.Forms
{
    public partial class FormConfiguration : Form
    {
        Packet packet;

        public FormConfiguration(Packet packet)
        {
            this.packet = packet;

            InitializeComponent();
            GetLevel();
        }

        private void GetLevel() => this.comboBoxMode.DataSource = Enum.GetValues(typeof(Level)).Cast<Level>();

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Level level = (Level)Enum.Parse(typeof(Level), this.comboBoxMode.SelectedItem.ToString());
            Led led = this.packet.Mode.Where(l => l.Level == level).FirstOrDefault();

            if (level == Level.Fail)
                this.numericUpDownTime.ReadOnly = true;
            else
                this.numericUpDownTime.ReadOnly = false;

            if (led is null)
                return;

            this.buttonColor.BackColor = Color.FromArgb(led.R, led.G, led.B);

            this.numericUpDownTime.TryValue(led.Time);
            this.numericUpDownAlpha.TryValue(led.A);
        }

        private void buttonSetUp_Click(object sender, EventArgs e)
        {
            Program.SerialService.Transmit((int)(Level)Enum.Parse(typeof(Level), this.comboBoxMode.SelectedItem.ToString()), new Led
            {
                R = this.buttonColor.BackColor.R,
                G = this.buttonColor.BackColor.G,
                B = this.buttonColor.BackColor.B,
                A = (int)this.numericUpDownAlpha.Value,
                Time = (int)this.numericUpDownTime.Value
            });

            Led led = this.packet.Mode.Where(l => l.Level == (Level)Enum.Parse(typeof(Level), this.comboBoxMode.SelectedItem.ToString())).FirstOrDefault();

            if (led is null)
                return;

            led.R = this.buttonColor.BackColor.R;
            led.G = this.buttonColor.BackColor.G;
            led.B = this.buttonColor.BackColor.B;
            led.A = (int)this.numericUpDownAlpha.Value;
            led.Time = (int)this.numericUpDownTime.Value;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() != DialogResult.Cancel)
                this.buttonColor.BackColor = dialog.Color;
        }

        private void FormConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SerialService.Transmit_Termination();
        }
    }
}
