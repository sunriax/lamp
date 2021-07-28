using Microsoft.Extensions.Configuration;
using RaGae.App.Lamp.Domain.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace RaGae.App.Lamp.Forms
{
    public partial class FormConnection : Form
    {
        private SerialConfig serialConfig;

        public FormConnection()
        {
            this.serialConfig = Program.SerialService.SerialConfig;
            this.InitializeComponent();
            this.GetSerialPorts();
            this.GetBaudRate();
            this.GetDataBits();
            this.GetParity();
            this.GetStopBits();
        }

        private void GetSerialPorts() =>this.SelectItem(comboBoxPort, this.serialConfig.Port, SerialPort.GetPortNames());

        private void GetBaudRate() => this.SelectItem(comboBoxBaudRate, this.serialConfig.Baud, Program.Configuration.GetSection(nameof(SerialPort)).GetSection(nameof(SerialPort.BaudRate)).Get<int[]>());

        private void GetDataBits() => this.SelectItem(comboBoxBits, this.serialConfig.DataBits, Program.Configuration.GetSection(nameof(SerialPort)).GetSection(nameof(SerialPort.DataBits)).Get<int[]>());

        private void GetParity() => this.SelectItem(comboBoxParity, this.serialConfig.Parity, Enum.GetValues(typeof(Parity)).Cast<Parity>().ToList());

        private void GetStopBits() => this.SelectItem(comboBoxStopBits, this.serialConfig.StopBits, Enum.GetValues(typeof(StopBits)).Cast<StopBits>().Skip(1).Take(2).ToList());

        private void SelectItem<T>(ComboBox box, T value, IEnumerable<T> data = null)
        {
            if (data is not null)
                box.DataSource = data;

            for (int i = 0; i < box.Items.Count; i++)
            {
                if (box.Items[i].ToString() == value.ToString())
                    box.SelectedIndex = i;
            }

            if (box.Items.Count > 0 && box.SelectedIndex < 0)
                box.SelectedIndex = 0;
        }

        private void pictureBoxFrame_Paint(object sender, PaintEventArgs e)
        {
            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int start_x = (int)((this.pictureBoxFrame.Width / 2) - (this.pictureBoxFrame.Width / 2 * 0.95));
            int start_y = (int)((this.pictureBoxFrame.Height / 2) - (this.pictureBoxFrame.Height / 2 * 0.75));

            int unit_x = (int)(pictureBoxFrame.Width * 0.95 / (2 + 5 + this.comboBoxBits.SelectedIndex + (this.comboBoxParity.SelectedIndex > 0 ? 1 : 0) + (this.comboBoxStopBits.SelectedIndex > 0 ? 2 : 1)));
            int unit_y = (int)(pictureBoxFrame.Height * 0.75);

            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            dev.DrawLine(Pens.Black, start_x, start_y, start_x + unit_x, start_y);
            dev.DrawLine(Pens.Black, start_x + unit_x, start_y, start_x + unit_x, start_y + unit_y);
            dev.DrawLine(Pens.Black, start_x + unit_x, start_y + unit_y, start_x + 2 * unit_x, start_y + unit_y);
            dev.DrawString("S", SystemFonts.DefaultFont, Brushes.Black, start_x + unit_x + unit_x / 2, start_y + unit_y / 2, stringFormat);

            for (int i = 0; i < (5 + this.comboBoxBits.SelectedIndex); i++)
            {
                dev.DrawRectangle(Pens.Black, start_x + unit_x * 2 + unit_x * i, start_y, unit_x, unit_y);
                dev.DrawString($"B{i}", SystemFonts.DefaultFont, Brushes.Black, start_x + unit_x * 2 + unit_x * i + unit_x / 2, start_y + unit_y / 2, stringFormat);
            }

            if (this.comboBoxParity.SelectedIndex > 0)
            {
                dev.DrawRectangle(Pens.Black, start_x + unit_x * 2 + unit_x * (5 + this.comboBoxBits.SelectedIndex), start_y, unit_x, unit_y);
                dev.DrawString($"P", SystemFonts.DefaultFont, Brushes.Black, start_x + unit_x * 2 + unit_x * (5 + this.comboBoxBits.SelectedIndex) + unit_x / 2, start_y + unit_y / 2, stringFormat);
            }

            dev.DrawLine(Pens.Black, start_x + unit_x * 2 + unit_x * ((5 + this.comboBoxBits.SelectedIndex) + (this.comboBoxParity.SelectedIndex > 0 ? 1 : 0)), start_y, start_x + unit_x * 3 + unit_x * ((5 + this.comboBoxBits.SelectedIndex) + (this.comboBoxParity.SelectedIndex > 0 ? 1 : 0) + 1), start_y);
            dev.DrawString($"E", SystemFonts.DefaultFont, Brushes.Black, start_x + unit_x * 2 + unit_x * ((5 + this.comboBoxBits.SelectedIndex) + (this.comboBoxParity.SelectedIndex > 0 ? 1 : 0)) + unit_x / 2, start_y + unit_y / 2, stringFormat);

            if (this.comboBoxStopBits.SelectedIndex > 0)
            {
                dev.DrawLine(Pens.Black, start_x + unit_x * 2 + unit_x * (5 + this.comboBoxBits.SelectedIndex) + (this.comboBoxParity.SelectedIndex > 0 ? 1 : 0), start_y, start_x + unit_x * 3 + unit_x * ((5 + this.comboBoxBits.SelectedIndex) + (this.comboBoxParity.SelectedIndex > 0 ? 1 : 0) + (this.comboBoxStopBits.SelectedIndex > 0 ? 2 : 0)), start_y);
                dev.DrawString($"E", SystemFonts.DefaultFont, Brushes.Black, start_x + unit_x * 3 + unit_x * ((5 + this.comboBoxBits.SelectedIndex) + (this.comboBoxParity.SelectedIndex > 0 ? 1 : 0)) + unit_x / 2, start_y + unit_y / 2, stringFormat);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) => this.pictureBoxFrame.Invalidate();

        private void FormConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.serialConfig.Port = this.comboBoxPort.Text;
            this.serialConfig.Baud = int.Parse(this.comboBoxBaudRate.SelectedItem.ToString());
            this.serialConfig.DataBits = int.Parse(this.comboBoxBits.SelectedItem.ToString()[0].ToString());
            this.serialConfig.Parity = (Parity)Enum.Parse(typeof(Parity), this.comboBoxParity.SelectedItem.ToString());
            this.serialConfig.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.comboBoxStopBits.SelectedItem.ToString());

            try
            {
                Program.SerialService.Setup();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, Resources.StringResource.ConnectionError, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
