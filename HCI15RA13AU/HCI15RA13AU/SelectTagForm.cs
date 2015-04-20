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
            foreach (Tag t in MainForm.tags)
            {
                lstAllTags.Items.Add(t.ID);
            }
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedTags = lstAllTags.SelectedItems;
            if (selectedTags.Count > 0)
            {
                foreach (var st in selectedTags)
                {
                    lstSelectedTags.SelectedItems.Add(st);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
