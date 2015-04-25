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
                lstAllTags.Items.Add(t.ID);
            }
        }

        public SelectTagForm(Dictionary<string, Tag> tags)
        {
            InitializeComponent();
            foreach (Tag t in MainForm.tags.Values)
            {
                if (tags.ContainsKey(t.ID))
                {
                    lstSelectedTags.Items.Add(t.ID);
                }
                else
                {
                    lstAllTags.Items.Add(t.ID);
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
                    tags.Add(st as string);
                }
                foreach (string t in tags)
                {
                    lstAllTags.Items.Remove(t);
                    lstSelectedTags.Items.Add(t);
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
                    tags.Add(st as string);
                }
                foreach (string t in tags)
                {
                    lstAllTags.Items.Remove(t);
                    lstSelectedTags.Items.Add(t);
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
                    tags.Add(st as string);
                }
                foreach (string t in tags)
                {
                    lstAllTags.Items.Add(t);
                    lstSelectedTags.Items.Remove(t);
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
                    tags.Add(st as string);
                }
                foreach (string t in tags)
                {
                    lstAllTags.Items.Add(t);
                    lstSelectedTags.Items.Remove(t);
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
                    tags.Add(st as string);
                }
            }
            return tags;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
