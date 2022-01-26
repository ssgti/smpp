using System;
using System.Windows.Forms;

namespace NEA_project
{
    public partial class AboutMenu : Form
    {
        public AboutMenu()
        {
            InitializeComponent();
        }

        private void repoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // will link to the project's GitHub repo
            // unnecessary code, doesn't work anyway

            repoLabel.LinkVisited = true;

            try
            {
                System.Diagnostics.Process.Start("link removed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
