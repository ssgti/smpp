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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? This will close the application", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string userID = user.getUserID();
                try
                {
                    // delete all entries for this user in Users and Selections
                    SQLOperations.sqlExecute("delete Users, Selections from Users inner join Selections on Selections.userID = Users.userID where Selections.userID = " + userID);
                }
                catch
                {
                    // if the user has no selections
                    SQLOperations.sqlExecute("delete from Users where userID = " + userID);
                }
            }
        }
    }
}
