using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HCI15RA13AU
{
    public partial class ResourcesTableForm : Form
    {
        public ResourcesTableForm()
        {
            InitializeComponent();
            menuStrip1.Hide();
        }

        private void dgwResources_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwResources.SelectedRows.Count == 0)
            {
                txtId.Text = "";
                txtFrequency.Text = "";
                txtName.Text = "";
                txtUnit.Text = "";
                chbExploatable.Checked = false;
                chbImportant.Checked = false;
                chbRenewable.Checked = false;
                txtDescription.Text = "";
                txtTypeId.Text = "";
                txtTypeName.Text = "";
                pbxIcon.Hide();
                pnlTags.Controls.Clear();
            }
            else
            {
                Resource res = (Resource)dgwResources.SelectedRows[0].Tag;
                if (res != null)
                {
                    txtId.Text = res.ID;
                    txtFrequency.Text = Resource.FrequencyToString(res.Frequency);
                    txtName.Text = res.Name;
                    txtUnit.Text = Resource.UnitToString(res.Unit);
                    chbExploatable.Checked = res.Exploatable;
                    chbImportant.Checked = res.Important;
                    chbRenewable.Checked = res.Renewable;
                    txtDescription.Text = res.Description;
                    txtTypeId.Text = res.Type.ID;
                    txtTypeName.Text = res.Type.Name;
                    pnlTags.Controls.Clear();
                    if (res.Tags.Count > 0)
                    {
                        int off = 3;
                        Label lbl;
                        
                        foreach (Tag t in res.Tags.Values)
                        {
                            lbl = new Label();
                            lbl.Width = 15 + 5 * t.ID.Length;
                            lbl.Text = t.ID;
                            lbl.BackColor = t.Color;
                            lbl.Left = off;
                            pnlTags.Controls.Add(lbl);
                            lbl.Left = off;
                            off += lbl.Width + 3;
                        }

                        pnlTags.Refresh();
                    }
                    pbxIcon.Show();
                    if (!res.IconFileName.Equals(""))
                    {
                        try
                        {
                            pbxIcon.Image = Image.FromFile(res.IconFileName);
                            pbxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (FileNotFoundException fnfe)
                        {
                            //pbxIcon.Image = pbxIcon.ErrorImage;
                            try
                            {
                                pbxIcon.Image = Image.FromFile(res.Type.IconFileName);
                                Console.WriteLine(fnfe.StackTrace);
                            }
                            catch (FileNotFoundException fnfe1)
                            {
                                pbxIcon.Image = pbxIcon.ErrorImage;
                                //pbxIcon.Image = Image.FromFile(res.Type.IconFileName);
                                Console.WriteLine(fnfe1.StackTrace);
                            }
                        }
                    }
                    else
                    {
                        pbxIcon.Image = Image.FromFile(res.Type.IconFileName);
                        //pbxIcon.Image = pbxIcon.InitialImage;
                    }
                }
            }
        }

        private void ResourcesTable_Load(object sender, EventArgs e)
        {
            string date;

            dgwResources.Rows.Clear();
            foreach (Resource res in MainForm.resources.Values)
            {
                date = res.Discovered.ToString(MainForm.dateFormat);

                if (res.ApproxDiscovered != null)
                {
                    date = res.ApproxDiscovered.ToString();
                }

                dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
                    date, res.Cost.ToString("C"), res.Important, res.Renewable,
                    Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
            }
            if (dgwResources.Rows.Count > 0)
            {
                dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            NewResourceForm addForm = new NewResourceForm();
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK)
            {
                
                Resource res = addForm.GetResource();
                string date =  res.Discovered.ToString(MainForm.dateFormat);

                if (res.ApproxDiscovered != null)
                {
                    date = res.ApproxDiscovered.ToString();
                }

                MainForm.resources.Add(res.ID, res);
                MainForm.addedResources.Add(res.ID);
                dgwResources.Rows.Add(new object[] { res.ID, res.Name, date,
                    res.Cost.ToString("C"), res.Important, res.Renewable,
                    Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit) });
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
                dgwResources.CurrentCell = dgwResources.Rows[dgwResources.Rows.Count - 1].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }

        private void btnEditResource_Click(object sender, EventArgs e)
        {
            if (dgwResources.SelectedRows.Count > 0)
            {
                NewResourceForm erf = new NewResourceForm((Resource)dgwResources.SelectedRows[0].Tag);
                erf.ShowDialog();

                if (erf.DialogResult == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgwResources.SelectedRows)
                    {
                        if (row.Selected)
                        {
                            Resource res = erf.GetResource();
                            String date = res.Discovered.ToString(MainForm.dateFormat);

                            if (res.ApproxDiscovered != null)
                            {
                                date = res.ApproxDiscovered.ToString();
                            }

                            int index = dgwResources.Rows.IndexOf(row);
                            dgwResources.Rows.RemoveAt(index);
                            dgwResources.Rows.Insert(index, new object[] { res.ID, res.Name, date,
                                res.Cost.ToString("C"), res.Important, res.Renewable,
                                Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit) });
                            dgwResources.Rows[index].Tag = res;
                            dgwResources.CurrentCell = dgwResources.Rows[index].Cells[0];
                            MainForm.resources.Remove(res.ID);
                            MainForm.resources.Add(res.ID, res);
                            break;
                        }
                    }
                    dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
                }
            }
        }

        private void btnDeleteResource_Click(object sender, EventArgs e)
        {
            if (dgwResources.SelectedRows.Count == 0)
                return;
            DataGridViewSelectedRowCollection selectedRows = dgwResources.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                if (row != null)
                {
                    int index = dgwResources.Rows.IndexOf(row);
                    Resource res = (Resource)row.Tag;
                    if (res != null)
                    {
                        MainForm.resources.Remove(res.ID);
                    }
                    dgwResources.Rows.RemoveAt(index);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string date;
            if (txtSearch.Text.Equals("") || !(chbId.Checked || chbName.Checked || chbType.Checked))
            {
                dgwResources.Rows.Clear();
                foreach (Resource res in MainForm.resources.Values)
                {
                    date = res.Discovered.ToString(MainForm.dateFormat);

                    if (res.ApproxDiscovered != null)
                    {
                        date = res.ApproxDiscovered.ToString();
                    }
                    dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
                    date, res.Cost.ToString("C"), res.Important, res.Renewable,
                    Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
                    dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
                }
                if (dgwResources.Rows.Count > 0)
                {
                    dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                    dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
                }
            }
            else
            {
                dgwResources.Rows.Clear();
                foreach (Resource res in MainForm.resources.Values)
                {
                    if ((res.ID.Contains(txtSearch.Text) && chbId.Checked) ||
                        (res.Name.Contains(txtSearch.Text) && chbName.Checked) ||
                        (res.Type.ID.Contains(txtSearch.Text) && chbType.Checked))
                    {
                        date = res.Discovered.ToString(MainForm.dateFormat);

                        if (res.ApproxDiscovered != null)
                        {
                            date = res.ApproxDiscovered.ToString();
                        }

                        dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
                        date, res.Cost.ToString("C"), res.Important, res.Renewable,
                        Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
                        dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
                    }
                }
                if (dgwResources.Rows.Count > 0)
                {
                    dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                    dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (btnFilter.Text.Equals("Ponisti filter"))
            {
                ResourcesTable_Load(this, EventArgs.Empty);
                btnFilter.Text = "Filtriraj";
                return;
            }
            ResourcesFilterForm resourcesFilter = new ResourcesFilterForm();
            resourcesFilter.ShowDialog();

            if (resourcesFilter.DialogResult == DialogResult.OK)
            {
                TableReload(resourcesFilter.GetResources());
                btnFilter.Text = "Ponisti filter";
            }
        }

        private void TableReload(List<Resource> list)
        {
            string date;

            dgwResources.Rows.Clear();
            foreach (Resource res in list)
            {
                date = res.Discovered.ToString(MainForm.dateFormat);

                if (res.ApproxDiscovered != null)
                {
                    date = res.ApproxDiscovered.ToString();
                }

                dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
                    date, res.Cost.ToString("C"), res.Important, res.Renewable,
                    Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
            }
            if (dgwResources.Rows.Count > 0)
            {
                dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }

        private void chbId_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(this, EventArgs.Empty);
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(this, EventArgs.Empty);
        }

        private void chbType_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(this, EventArgs.Empty);
        }

        private void dgwResources_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnEditResource_Click(this, EventArgs.Empty);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.saveToolStripMenuItem_Click(sender, e);
        }
    }
}
