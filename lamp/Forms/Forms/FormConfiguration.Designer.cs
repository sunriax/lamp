
namespace RaGae.App.Lamp.Forms
{
    partial class FormConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
            this.groupBoxConfiguration = new System.Windows.Forms.GroupBox();
            this.numericUpDownAlpha = new System.Windows.Forms.NumericUpDown();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.buttonSetUp = new System.Windows.Forms.Button();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.groupBoxConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConfiguration
            // 
            this.groupBoxConfiguration.Controls.Add(this.numericUpDownAlpha);
            this.groupBoxConfiguration.Controls.Add(this.labelAlpha);
            this.groupBoxConfiguration.Controls.Add(this.buttonSetUp);
            this.groupBoxConfiguration.Controls.Add(this.numericUpDownTime);
            this.groupBoxConfiguration.Controls.Add(this.labelTime);
            this.groupBoxConfiguration.Controls.Add(this.buttonColor);
            this.groupBoxConfiguration.Controls.Add(this.comboBoxMode);
            this.groupBoxConfiguration.Location = new System.Drawing.Point(13, 13);
            this.groupBoxConfiguration.Name = "groupBoxConfiguration";
            this.groupBoxConfiguration.Size = new System.Drawing.Size(303, 113);
            this.groupBoxConfiguration.TabIndex = 0;
            this.groupBoxConfiguration.TabStop = false;
            this.groupBoxConfiguration.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConfiguration_groupBoxConfiguration;
            // 
            // numericUpDownAlpha
            // 
            this.numericUpDownAlpha.Location = new System.Drawing.Point(8, 74);
            this.numericUpDownAlpha.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAlpha.Name = "numericUpDownAlpha";
            this.numericUpDownAlpha.Size = new System.Drawing.Size(72, 23);
            this.numericUpDownAlpha.TabIndex = 6;
            this.numericUpDownAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Location = new System.Drawing.Point(8, 54);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(41, 15);
            this.labelAlpha.TabIndex = 5;
            this.labelAlpha.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConfiguration_labelAlpha;
            // 
            // buttonSetUp
            // 
            this.buttonSetUp.Location = new System.Drawing.Point(195, 23);
            this.buttonSetUp.Name = "buttonSetUp";
            this.buttonSetUp.Size = new System.Drawing.Size(96, 74);
            this.buttonSetUp.TabIndex = 4;
            this.buttonSetUp.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConfiguration_buttonSetUp;
            this.buttonSetUp.UseVisualStyleBackColor = true;
            this.buttonSetUp.Click += new System.EventHandler(this.buttonSetUp_Click);
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(116, 74);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(73, 23);
            this.numericUpDownTime.TabIndex = 3;
            this.numericUpDownTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(116, 54);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 15);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConfiguration_labelTime;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(101, 23);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(88, 25);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConfiguration_buttonColor;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(7, 23);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(88, 23);
            this.comboBoxMode.TabIndex = 0;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 141);
            this.Controls.Add(this.groupBoxConfiguration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConfiguration";
            this.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormConfiguration_Text;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfiguration_FormClosing);
            this.groupBoxConfiguration.ResumeLayout(false);
            this.groupBoxConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfiguration;
        private System.Windows.Forms.Button buttonSetUp;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.NumericUpDown numericUpDownAlpha;
        private System.Windows.Forms.Label labelAlpha;
    }
}