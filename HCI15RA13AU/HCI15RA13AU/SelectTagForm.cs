using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI15RA13AU
{
    public partial class SelectTagForm : Form
    {
        public SelectTagForm()
        {
            InitializeComponent();
            foreach (Tag t in MainForm.tags.Values)
            {
                lstAllTags.Items.Add(t.SecondID);
            }
        }

        public SelectTagForm(Dictionary<string, Tag> tags)
        {
            InitializeComponent();
            foreach (Tag t in MainForm.tags.Values)
            {
                if (tags.ContainsKey(t.ID))
                {
                    lstSelectedTags.Items.Add(t.SecondID);
                }
                else
                {
                    lstAllTags.Items.Add(t.SecondID);
                }
            }
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedTags = lstAllTags.SelectedItems;
            List<string> tags = new List<string>();
            if (selectedTags.Count > 0)
            {
                foreach (var st in selectedTags)
                {
                    tags.Add(MainForm.GetTagBySecondID(st as string).ID);
                }
                foreach (string t in tags)
                {
                    lstAllTags.Items.Remove(MainForm.tags[t].SecondID);
                    lstSelectedTags.Items.Add(MainForm.tags[t].SecondID);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection selectedTags = lstAllTags.Items;
            List<string> tags = new List<string>();
            if (selectedTags.Count > 0)
            {
                foreach (var st in selectedTags)
                {
                    tags.Add(MainForm.GetTagBySecondID(st as string).ID);
                }
                foreach (string t in tags)
                {
                    lstAllTags.Items.Remove(MainForm.tags[t].SecondID);
                    lstSelectedTags.Items.Add(MainForm.tags[t].SecondID);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedTags = lstSelectedTags.SelectedItems;
            List<string> tags = new List<string>();
            if (selectedTags.Count > 0)
            {
                foreach (var st in selectedTags)
                {
                    tags.Add(MainForm.GetTagBySecondID(st as string).ID);
                }
                foreach (string t in tags)
                {
                    lstAllTags.Items.Add(MainForm.tags[t].SecondID);
                    lstSelectedTags.Items.Remove(MainForm.tags[t].SecondID);
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection selectedTags = lstSelectedTags.Items;
            List<string> tags = new List<string>();
            if (selectedTags.Count > 0)
            {
                foreach (var st in selectedTags)
                {
                    tags.Add(MainForm.GetTagBySecondID(st as string).ID);
                }
                foreach (string t in tags)
                {
                    lstAllTags.Items.Add(MainForm.tags[t].SecondID);
                    lstSelectedTags.Items.Remove(MainForm.tags[t].SecondID);
                }
            }
        }

        public List<string> GetSelectedTags()
        {
            ListBox.ObjectCollection selectedTags = lstSelectedTags.Items;
            List<string> tags = new List<string>();
            if (selectedTags.Count > 0)
            {
                foreach (var st in selectedTags)
                {
                    tags.Add(MainForm.GetTagBySecondID(st as string).ID);
                }
            }
            return tags;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            lstAllTags.Items.Clear();

            Dictionary<string, Tag> tags = new Dictionary<string, Tag>(MainForm.tags);
            foreach (var item in lstSelectedTags.Items)
            {
                if (MainForm.tags.ContainsKey(MainForm.GetTagBySecondID(item as string).ID))
                {
                    tags.Remove(MainForm.GetTagBySecondID(item as string).ID);
                }
            }
            if (txtTag.Text.Equals(""))
            {
                foreach (Tag t in tags.Values)
                {
                    lstAllTags.Items.Add(t.SecondID);
                }
            }
            else
            {
                foreach (Tag t in tags.Values)
                {
                    if (t.SecondID.StartsWith(txtTag.Text))
                    {
                        lstAllTags.Items.Add(t.SecondID);
                    }
                }
            }
        }
    }
}
