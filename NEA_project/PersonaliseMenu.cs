using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace NEA_project
{
    public partial class PersonaliseMenu : Form
    {
        public PersonaliseMenu()
        {
            InitializeComponent();
            // updateList();
        }

        private void updateList()
        {
            // fill selection list from database

            string connStr = "server=127.0.0.1;user=snoop;database=mydb;port=3306;password=snoopin321";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "select name from Financial";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                selectionList.BeginUpdate();
                while (rdr.Read())
                {
                    selectionList.Items.Add(rdr.ToString());
                }
                rdr.Close();
                selectionList.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // add selected items from selectionList list to selectedList
            int i = 0;
            bool exists = false;
            selectedList.BeginUpdate();
            do
            {
                for(int x = 0; x < selectedList.Items.Count; i++) // checks if the item to be added is already in selectedList
                {
                    if(selectionList.SelectedItems[i] == selectedList.Items[i])
                    {
                        exists = true;
                    }
                }
                if (exists == false) // add item if it is not already in selectedList
                {
                    selectedList.Items.Add(selectionList.SelectedItems[i].ToString());
                }
                exists = false;
                i++;
            } while (i <= selectionList.SelectedItems.Count); // do this for every selected item in selectionList
            selectedList.EndUpdate();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // remove selected items from selectedList
            selectedList.BeginUpdate();
            for(int i = 0; i < selectionList.SelectedItems.Count; i++)
            {
                for(int x = 0; x < selectedList.Items.Count; x++)
                {
                    if(selectionList.SelectedItems[i] == selectedList.Items[x])
                    {
                        selectedList.Items.RemoveAt(x); // if items match, remove the entry in selectedList
                    }
                }
            }
            selectedList.EndUpdate();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // clear selectedList
            selectedList.BeginUpdate();
            selectedList.Items.Clear();
            selectedList.EndUpdate();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // upload user list to database
        }
    }
}
