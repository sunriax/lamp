
namespace RaGae.App.Lamp.Forms
{
    partial class FormConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnection));
            this.groupBoxSerial = new System.Windows.Forms.GroupBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelAt = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.groupBoxFrame = new System.Windows.Forms.GroupBox();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.comboBoxBits = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.labelStopbits = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this.groupBoxSerial.SuspendLayout();
            this.groupBoxFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSerial
            // 
            this.groupBoxSerial.Controls.Add(this.labelBaud);
            this.groupBoxSerial.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxSerial.Controls.Add(this.labelAt);
            this.groupBoxSerial.Controls.Add(this.comboBoxPort);
            this.groupBoxSerial.Controls.Add(this.labelPort);
            this.groupBoxSerial.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSerial.Name = "groupBoxSerial";
            this.groupBoxSerial.Size = new System.Drawing.Size(434, 60);
            this.groupBoxSerial.TabIndex = 0;
            this.groupBoxSerial.TabStop = false;
            this.groupBoxSerial.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_groupBoxSerial;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(394, 26);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(34, 15);
            this.labelBaud.TabIndex = 6;
            this.labelBaud.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_labelBaud;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(262, 23);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(125, 23);
            this.comboBoxBaudRate.TabIndex = 3;
            // 
            // labelAt
            // 
            this.labelAt.AutoSize = true;
            this.labelAt.Location = new System.Drawing.Point(238, 26);
            this.labelAt.Name = "labelAt";
            this.labelAt.Size = new System.Drawing.Size(18, 15);
            this.labelAt.TabIndex = 2;
            this.labelAt.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_labelAt;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(45, 23);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(187, 23);
            this.comboBoxPort.TabIndex = 1;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(7, 26);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(32, 15);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_labelPort;
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxFrame
            // 
            this.groupBoxFrame.Controls.Add(this.labelDataBits);
            this.groupBoxFrame.Controls.Add(this.comboBoxBits);
            this.groupBoxFrame.Controls.Add(this.labelParity);
            this.groupBoxFrame.Controls.Add(this.comboBoxParity);
            this.groupBoxFrame.Controls.Add(this.labelStopbits);
            this.groupBoxFrame.Controls.Add(this.comboBoxStopBits);
            this.groupBoxFrame.Controls.Add(this.pictureBoxFrame);
            this.groupBoxFrame.Location = new System.Drawing.Point(13, 79);
            this.groupBoxFrame.Name = "groupBoxFrame";
            this.groupBoxFrame.Size = new System.Drawing.Size(434, 161);
            this.groupBoxFrame.TabIndex = 1;
            this.groupBoxFrame.TabStop = false;
            this.groupBoxFrame.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_groupBoxFrame;
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(116, 134);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(50, 15);
            this.labelDataBits.TabIndex = 11;
            this.labelDataBits.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_labelDataBits;
            // 
            // comboBoxBits
            // 
            this.comboBoxBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBits.FormattingEnabled = true;
            this.comboBoxBits.Location = new System.Drawing.Point(116, 108);
            this.comboBoxBits.Name = "comboBoxBits";
            this.comboBoxBits.Size = new System.Drawing.Size(100, 23);
            this.comboBoxBits.TabIndex = 10;
            this.comboBoxBits.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(222, 134);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(37, 15);
            this.labelParity.TabIndex = 9;
            this.labelParity.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_labelParity;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(222, 108);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(100, 23);
            this.comboBoxParity.TabIndex = 8;
            this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // labelStopbits
            // 
            this.labelStopbits.AutoSize = true;
            this.labelStopbits.Location = new System.Drawing.Point(328, 134);
            this.labelStopbits.Name = "labelStopbits";
            this.labelStopbits.Size = new System.Drawing.Size(58, 15);
            this.labelStopbits.TabIndex = 7;
            this.labelStopbits.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_labelStopbits;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(328, 108);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(100, 23);
            this.comboBoxStopBits.TabIndex = 5;
            this.comboBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // pictureBoxFrame
            // 
            this.pictureBoxFrame.Location = new System.Drawing.Point(7, 23);
            this.pictureBoxFrame.Name = "pictureBoxFrame";
            this.pictureBoxFrame.Size = new System.Drawing.Size(421, 79);
            this.pictureBoxFrame.TabIndex = 0;
            this.pictureBoxFrame.TabStop = false;
            this.pictureBoxFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxFrame_Paint);
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 249);
            this.Controls.Add(this.groupBoxFrame);
            this.Controls.Add(this.groupBoxSerial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConnection";
            this.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConnection_Text;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnection_FormClosing);
            this.groupBoxSerial.ResumeLayout(false);
            this.groupBoxSerial.PerformLayout();
            this.groupBoxFrame.ResumeLayout(false);
            this.groupBoxFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSerial;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label labelAt;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.GroupBox groupBoxFrame;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.ComboBox comboBoxBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label labelStopbits;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.PictureBox pictureBoxFrame;
    }
}