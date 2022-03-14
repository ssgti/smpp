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

            List<string> selections = SQLOperations.sqlSelect("select name from Selections");
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

            SQLOperations.sqlExecute("truncate table selections");
            for (int x = 0; x < selectedList.Items.Count; x++)
            {
                SQLOperations.sqlExecute("insert into selections(selectionID, name) values(" + x + ", \"" + selectedList.Items[x].ToString() + "\")");
            }
        }
    }
}
