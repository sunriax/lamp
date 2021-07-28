
namespace RaGae.App.Lamp.Forms
{
    partial class FormMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessage));
            this.groupBoxNotification = new System.Windows.Forms.GroupBox();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.labelTime = new System.Windows.Forms.Label();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.groupBoxNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNotification
            // 
            this.groupBoxNotification.Controls.Add(this.numericUpDownTime);
            this.groupBoxNotification.Controls.Add(this.labelTime);
            this.groupBoxNotification.Controls.Add(this.richTextBoxText);
            this.groupBoxNotification.Controls.Add(this.labelText);
            this.groupBoxNotification.Controls.Add(this.labelTitle);
            this.groupBoxNotification.Controls.Add(this.textBoxTitle);
            this.groupBoxNotification.Location = new System.Drawing.Point(13, 13);
            this.groupBoxNotification.Name = "groupBoxNotification";
            this.groupBoxNotification.Size = new System.Drawing.Size(277, 141);
            this.groupBoxNotification.TabIndex = 0;
            this.groupBoxNotification.TabStop = false;
            this.groupBoxNotification.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormMessage_groupBoxNotification;
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(62, 106);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownTime.TabIndex = 6;
            this.numericUpDownTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(6, 106);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(50, 23);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormMessage_labelTime;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(62, 52);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(200, 50);
            this.richTextBoxText.TabIndex = 4;
            this.richTextBoxText.Text = "";
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(6, 51);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(50, 23);
            this.labelText.TabIndex = 3;
            this.labelText.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormMessage_labelText;
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(6, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(50, 23);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormMessage_labelTitle;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(62, 23);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 23);
            this.textBoxTitle.TabIndex = 0;
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 164);
            this.Controls.Add(this.groupBoxNotification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMessage";
            this.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormMessage_Text;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMessage_FormClosing);
            this.Load += new System.EventHandler(this.FormMessage_Load);
            this.groupBoxNotification.ResumeLayout(false);
            this.groupBoxNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNotification;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
    }
}