using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace RaGae.App.Lamp.Forms
{
    public partial class FormVersion : Form
    {
        private string version;

        public FormVersion(string version)
        {
            this.version = string.IsNullOrWhiteSpace(version) ? "?" : version;

            InitializeComponent();
        }

        private void FormVersion_Load(object sender, EventArgs e)
        {
            this.labelNameRef.Text = Assembly.GetExecutingAssembly().GetName().Name;
            this.labelVersionRef.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            this.labelProtocolRef.Text = version;

            this.labelAuthorRef.Text = Resources.StringResource.Author;
            this.labelCompanyRef.Text = Resources.StringResource.Company;
            this.labelLinkRef.Text = Resources.StringResource.Link;
        }

        private void labelWWWRef_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(Resources.StringResource.Link) { UseShellExecute = true });
            }
            catch { }
        }
    }
}
