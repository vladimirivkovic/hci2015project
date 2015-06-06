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
    public partial class TagsTableForm : Form
    {
        public TagsTableForm()
        {
            InitializeComponent();
        }

        private void btnNewTag_Click(object sender, EventArgs e)
        {
            TagForm nt = new TagForm();
            nt.ShowDialog();

            if (nt.DialogResult == DialogResult.OK)
            {
                Tag t = nt.GetTag();
                MainForm.tags.Add(t.ID, t);

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = t.Color;
                dgwTags.Rows.Add(new object[] { t.SecondID, "" });
                dgwTags.Rows[dgwTags.Rows.Count - 1].Tag = t;
                dgwTags.Rows[dgwTags.Rows.Count - 1].Cells[1].Style = cellStyle;
                dgwTags.CurrentCell = dgwTags.Rows[dgwTags.Rows.Count - 1].Cells[0];
            }
        }

        private void btnEditTag_Click(object sender, EventArgs e)
        {
            if (dgwTags.SelectedRows.Count > 0)
            {
                TagForm tf = new TagForm((Tag)dgwTags.SelectedRows[0].Tag);
                tf.ShowDialog();

                if (tf.DialogResult == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgwTags.SelectedRows)
                    {
                        if (row.Selected)
                        {
                            Tag t = tf.GetTag();

                            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                            cellStyle.BackColor = t.Color;

                            int index = dgwTags.Rows.IndexOf(row);
                            dgwTags.Rows.RemoveAt(index);
                            dgwTags.Rows.Insert(index, new object[] { t.SecondID, "" });
                            dgwTags.Rows[index].Tag = t;
                            dgwTags.Rows[index].Cells[1].Style = cellStyle;
                            dgwTags.CurrentCell = dgwTags.Rows[index].Cells[0];
                            MainForm.tags[t.ID] = t;
                            break;
                        }
                    }
                }
            }
        }

        private void btnDeleteTag_Click(object sender, EventArgs e)
        {
            if (dgwTags.SelectedRows.Count == 0)
                return;
            DataGridViewSelectedRowCollection rows = dgwTags.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                if (row != null)
                {
                    int index = dgwTags.Rows.IndexOf(row);
                    Tag t = (Tag)row.Tag;
                    if (t != null)
                    {
                        List<Resource> deleted = new List<Resource>();
                        foreach (Resource res in MainForm.resources.Values)
                        {
                            //bool contains = false;
                            foreach (Tag tg in res.Tags.Values)
                            {
                                if (tg.ID == t.ID)
                                {
                                    deleted.Add(res);
                                }
                            }
                        }
                        foreach (Resource res in deleted)
                        {
                            if (res.Tags.ContainsKey(t.ID))
                            {
                                MainForm.resources[res.ID].Tags.Remove(t.ID);
                            }
                        }
                        MainForm.tags.Remove(t.ID);
                        //dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
                    }
                    dgwTags.Rows.RemoveAt(index);
                }
            }
        }

        private void TagsTable_Load(object sender, EventArgs e)
        {
            dgwTags.Rows.Clear();
            foreach (Tag t in MainForm.tags.Values)
            {
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = t.Color;
                dgwTags.Rows.Add(new object[] { t.SecondID, "" });
                dgwTags.Rows[dgwTags.Rows.Count - 1].Tag = t;
                dgwTags.Rows[dgwTags.Rows.Count - 1].Cells[1].Style = cellStyle;
            }
            if (dgwTags.Rows.Count > 0)
            {
                dgwTags.CurrentCell = dgwTags.Rows[0].Cells[0];
                dgwTags_SelectionChanged(dgwTags, EventArgs.Empty);
            }
        }

        private void dgwTags_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwTags.SelectedRows.Count == 0)
            {
                txtTagDesc.Text = "";
                txtColor.ForeColor = Color.White;
                txtColor.BackColor = Color.White;
            }
            else
            {
                Tag t = (Tag)dgwTags.SelectedRows[0].Tag;
                if (t != null)
                {
                    txtTagDesc.Text = t.Description;
                    txtColor.BackColor = t.Color;
                }
            }
        }

        private void dgwTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditTag_Click(this, EventArgs.Empty);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnNewTag_Click(this, EventArgs.Empty);
                return true;
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                btnDeleteTag_Click(this, EventArgs.Empty);
                return true;
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnEditTag_Click(this, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
