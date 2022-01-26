using System;
using System.Windows.Forms;

namespace NEA_project
{
    public partial class DebugMenu : Form
    {
        public DebugMenu()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
        }

        private void persBtn_Click(object sender, EventArgs e)
        {
            PersonaliseMenu personalise = new PersonaliseMenu();
            personalise.Show();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutMenu about = new AboutMenu();
            about.Show();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            /*
            string connStr = "server=127.0.0.1;user=snoop;database=mydb;port=3306;password=snoopin321";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Successful", "Connect to Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            */
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
             // menu for configuring the database connection string
            //  low priority so i'll do it later
        }
    }
}
