
namespace RaGae.App.Lamp.Forms
{
    partial class FormVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVersion));
            this.groupBoxAssembly = new System.Windows.Forms.GroupBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelVersionRef = new System.Windows.Forms.Label();
            this.labelNameRef = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxCreator = new System.Windows.Forms.GroupBox();
            this.labelLinkRef = new System.Windows.Forms.LinkLabel();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCompanyRef = new System.Windows.Forms.Label();
            this.labelAuthorRef = new System.Windows.Forms.Label();
            this.groupBoxPackage = new System.Windows.Forms.GroupBox();
            this.labelProtocolRef = new System.Windows.Forms.Label();
            this.labelProtocol = new System.Windows.Forms.Label();
            this.groupBoxAssembly.SuspendLayout();
            this.groupBoxCreator.SuspendLayout();
            this.groupBoxPackage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAssembly
            // 
            this.groupBoxAssembly.Controls.Add(this.labelVersion);
            this.groupBoxAssembly.Controls.Add(this.labelVersionRef);
            this.groupBoxAssembly.Controls.Add(this.labelNameRef);
            this.groupBoxAssembly.Controls.Add(this.labelName);
            this.groupBoxAssembly.Location = new System.Drawing.Point(13, 13);
            this.groupBoxAssembly.Name = "groupBoxAssembly";
            this.groupBoxAssembly.Size = new System.Drawing.Size(318, 58);
            this.groupBoxAssembly.TabIndex = 0;
            this.groupBoxAssembly.TabStop = false;
            this.groupBoxAssembly.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_groupBoxAssembly;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(6, 34);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(84, 15);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelVersion;
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVersionRef
            // 
            this.labelVersionRef.AutoSize = true;
            this.labelVersionRef.Location = new System.Drawing.Point(96, 34);
            this.labelVersionRef.Name = "labelVersionRef";
            this.labelVersionRef.Size = new System.Drawing.Size(12, 15);
            this.labelVersionRef.TabIndex = 3;
            this.labelVersionRef.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelVersionRef;
            // 
            // labelNameRef
            // 
            this.labelNameRef.AutoSize = true;
            this.labelNameRef.Location = new System.Drawing.Point(96, 19);
            this.labelNameRef.Name = "labelNameRef";
            this.labelNameRef.Size = new System.Drawing.Size(12, 15);
            this.labelNameRef.TabIndex = 2;
            this.labelNameRef.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelNameRef;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(6, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelName;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxCreator
            // 
            this.groupBoxCreator.Controls.Add(this.labelLinkRef);
            this.groupBoxCreator.Controls.Add(this.labelLink);
            this.groupBoxCreator.Controls.Add(this.labelCompany);
            this.groupBoxCreator.Controls.Add(this.labelAuthor);
            this.groupBoxCreator.Controls.Add(this.labelCompanyRef);
            this.groupBoxCreator.Controls.Add(this.labelAuthorRef);
            this.groupBoxCreator.Location = new System.Drawing.Point(13, 125);
            this.groupBoxCreator.Name = "groupBoxCreator";
            this.groupBoxCreator.Size = new System.Drawing.Size(318, 74);
            this.groupBoxCreator.TabIndex = 4;
            this.groupBoxCreator.TabStop = false;
            this.groupBoxCreator.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_groupBoxCreator;
            // 
            // labelLinkRef
            // 
            this.labelLinkRef.AutoSize = true;
            this.labelLinkRef.Location = new System.Drawing.Point(96, 49);
            this.labelLinkRef.Name = "labelLinkRef";
            this.labelLinkRef.Size = new System.Drawing.Size(12, 15);
            this.labelLinkRef.TabIndex = 8;
            this.labelLinkRef.TabStop = true;
            this.labelLinkRef.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelLinkRef;
            this.labelLinkRef.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelWWWRef_LinkClicked);
            // 
            // labelLink
            // 
            this.labelLink.Location = new System.Drawing.Point(6, 49);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(84, 15);
            this.labelLink.TabIndex = 7;
            this.labelLink.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelLink;
            this.labelLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCompany
            // 
            this.labelCompany.Location = new System.Drawing.Point(6, 34);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(84, 15);
            this.labelCompany.TabIndex = 5;
            this.labelCompany.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelCompany;
            this.labelCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Location = new System.Drawing.Point(6, 19);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(84, 15);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelAuthor;
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCompanyRef
            // 
            this.labelCompanyRef.AutoSize = true;
            this.labelCompanyRef.Location = new System.Drawing.Point(96, 34);
            this.labelCompanyRef.Name = "labelCompanyRef";
            this.labelCompanyRef.Size = new System.Drawing.Size(12, 15);
            this.labelCompanyRef.TabIndex = 3;
            this.labelCompanyRef.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelCompanyRef;
            // 
            // labelAuthorRef
            // 
            this.labelAuthorRef.AutoSize = true;
            this.labelAuthorRef.Location = new System.Drawing.Point(96, 19);
            this.labelAuthorRef.Name = "labelAuthorRef";
            this.labelAuthorRef.Size = new System.Drawing.Size(12, 15);
            this.labelAuthorRef.TabIndex = 2;
            this.labelAuthorRef.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelAuthorRef;
            // 
            // groupBoxPackage
            // 
            this.groupBoxPackage.Controls.Add(this.labelProtocolRef);
            this.groupBoxPackage.Controls.Add(this.labelProtocol);
            this.groupBoxPackage.Location = new System.Drawing.Point(13, 77);
            this.groupBoxPackage.Name = "groupBoxPackage";
            this.groupBoxPackage.Size = new System.Drawing.Size(318, 42);
            this.groupBoxPackage.TabIndex = 5;
            this.groupBoxPackage.TabStop = false;
            this.groupBoxPackage.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_groupBoxPackage;
            // 
            // labelProtocolRef
            // 
            this.labelProtocolRef.AutoSize = true;
            this.labelProtocolRef.Location = new System.Drawing.Point(96, 19);
            this.labelProtocolRef.Name = "labelProtocolRef";
            this.labelProtocolRef.Size = new System.Drawing.Size(12, 15);
            this.labelProtocolRef.TabIndex = 2;
            this.labelProtocolRef.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelProtocolRef;
            // 
            // labelProtocol
            // 
            this.labelProtocol.Location = new System.Drawing.Point(6, 19);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(84, 15);
            this.labelProtocol.TabIndex = 0;
            this.labelProtocol.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_labelProtocol;
            this.labelProtocol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 207);
            this.Controls.Add(this.groupBoxPackage);
            this.Controls.Add(this.groupBoxCreator);
            this.Controls.Add(this.groupBoxAssembly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVersion";
            this.Text = global::RaGae.App.Lamp.Forms.Resources.StringResource.FormVersion_Text;
            this.Load += new System.EventHandler(this.FormVersion_Load);
            this.groupBoxAssembly.ResumeLayout(false);
            this.groupBoxAssembly.PerformLayout();
            this.groupBoxCreator.ResumeLayout(false);
            this.groupBoxCreator.PerformLayout();
            this.groupBoxPackage.ResumeLayout(false);
            this.groupBoxPackage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAssembly;
        private System.Windows.Forms.Label labelVersionRef;
        private System.Windows.Forms.Label labelNameRef;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxCreator;
        private System.Windows.Forms.Label labelCompanyRef;
        private System.Windows.Forms.Label labelAuthorRef;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.LinkLabel labelLinkRef;
        private System.Windows.Forms.GroupBox groupBoxPackage;
        private System.Windows.Forms.Label labelProtocolRef;
        private System.Windows.Forms.Label labelProtocol;
    }
}