using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NEA_project
{
    public partial class PersonaliseMenu : Form
    {
        public PersonaliseMenu()
        {
            InitializeComponent();
            getSelections();
            updateList();
        }

        private void getSelections()
        {
            // fill selected list from database
            string userID = user.getUserID();
            List<string> selections = SQLOperations.sqlSelect("select name from Selections where userID = \"" + userID + "\"");
            selectedList.BeginUpdate();
            for (int i = 0; i < selections.Count; i++)
            {
                selectedList.Items.Add(selections[i]);
            }
            selectedList.EndUpdate();
        }

        private void updateList()
        {
            // fill selection list from database
            List<string> names = SQLOperations.sqlSelect("select name from Financial");
            selectionList.BeginUpdate();
            for (int i = 0; i < names.Count; i++)
            {
                selectionList.Items.Add(names[i]);
            }
            selectionList.EndUpdate();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // add selected items from selectionList list to selectedList
            int i = 0;
            bool exists = false;
            selectedList.BeginUpdate();
            do
            {
                try
                {
                    for (int x = 0; x < selectedList.Items.Count; x++) // checks if the item to be added is already in selectedList
                    {
                        if(selectionList.SelectedItems[i].ToString() == selectedList.Items[x].ToString())
                        {
                            exists = true;
                        }
                    }
                    if (!exists) // add item if it is not already in selectedList
                    {
                        selectedList.Items.Add(selectionList.SelectedItems[i].ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("No items selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                exists = false;
                i++;
            } while (i < selectionList.SelectedItems.Count); // do this for every selected item in selectionList
            selectedList.EndUpdate();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // remove selected items from selectedList
            selectedList.BeginUpdate();
            if(selectionList.SelectedItems.Count != 0 && selectedList.Items.Count != 0)
            {
                for(int i = 0; i < selectionList.SelectedItems.Count; i++)
                {
                    for(int x = 0; x < selectedList.Items.Count; x++)
                    {
                        if(selectionList.SelectedItems[i].ToString() == selectedList.Items[x].ToString())
                        {
                            selectedList.Items.RemoveAt(x); // if items match, remove the entry in selectedList
                        }
                    }
                }
            }
            else if(selectionList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No items selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nothing to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            selectedList.EndUpdate();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // clear selectedList
            if(selectedList.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure? This cannot be undone", "Reset Selections", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    selectedList.BeginUpdate();
                    selectedList.Items.Clear();
                    selectedList.EndUpdate();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // upload user list to database
            string userID = user.getUserID();
            SQLOperations.sqlExecute("delete from selections where userID = \"" + userID + "\"");
            for (int x = 0; x < selectedList.Items.Count; x++)
            {
                int sID = SQLOperations.autoIncrementID("selectionID", "selections"); // get an automatically incremented ID
                List<string> fID = SQLOperations.sqlSelect("select financialID from financial where name = \"" + selectedList.Items[x].ToString() + "\"");
                SQLOperations.sqlExecute("insert into selections values(" + sID + ", \"" + selectedList.Items[x].ToString() + "\", 0, \"" + userID + "\", " + fID[0] + ")");
            }
            MessageBox.Show("Selections saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
