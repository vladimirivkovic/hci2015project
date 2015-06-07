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
        private SolidBrush tagsBackgroundBrushSelected = new SolidBrush(Color.FromKnownColor(KnownColor.Highlight));
        private SolidBrush tagsForegroundBrushSelected = new SolidBrush(Color.White);


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

        private void lstAllTags_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            int index = e.Index;
            if (index >= 0 && index < lstAllTags.Items.Count)
            {
                string text = lstAllTags.Items[index].ToString();
                Graphics g = e.Graphics;

                //background:
                SolidBrush backgroundBrush;
                if (selected)
                    backgroundBrush = tagsBackgroundBrushSelected;
                else
                {
                    backgroundBrush = new SolidBrush(MainForm.GetTagBySecondID(text).Color);
                }
                g.FillRectangle(backgroundBrush, e.Bounds);

                //text:
                SolidBrush foregroundBrush = (selected) ? tagsForegroundBrushSelected : new SolidBrush(HSV.Complementary(MainForm.GetTagBySecondID(text).Color));
                g.DrawString(text, e.Font, foregroundBrush, lstAllTags.GetItemRectangle(index).Location);
            }

            e.DrawFocusRectangle();
        }

        private void lstSelectedTags_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            int index = e.Index;
            if (index >= 0 && index < lstSelectedTags.Items.Count)
            {
                string text = lstSelectedTags.Items[index].ToString();
                Graphics g = e.Graphics;

                //background:
                SolidBrush backgroundBrush;
                if (selected)
                    backgroundBrush = tagsBackgroundBrushSelected;
                else
                {
                    backgroundBrush = new SolidBrush(MainForm.GetTagBySecondID(text).Color);
                }
                g.FillRectangle(backgroundBrush, e.Bounds);

                //text:
                SolidBrush foregroundBrush = (selected) ? tagsForegroundBrushSelected : new SolidBrush(HSV.Complementary(MainForm.GetTagBySecondID(text).Color));
                g.DrawString(text, e.Font, foregroundBrush, lstSelectedTags.GetItemRectangle(index).Location);
            }

            e.DrawFocusRectangle();
        }
    }
}
