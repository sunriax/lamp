using RaGae.App.Lamp.Forms.Extensions;
using System;
using System.Windows.Forms;

namespace RaGae.App.Lamp.Forms
{
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            this.textBoxTitle.Text = Program.SystemConfig.BallonTitle;
            this.richTextBoxText.Text = Program.SystemConfig.BallonText;
            this.numericUpDownTime.TryValue(Program.SystemConfig.BallonTime);
        }

        private void FormMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SystemConfig.BallonTitle = this.textBoxTitle.Text;
            Program.SystemConfig.BallonText = this.richTextBoxText.Text;
            Program.SystemConfig.BallonTime = (int)this.numericUpDownTime.Value;
        }
    }
}
