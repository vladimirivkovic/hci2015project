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
    public partial class MainForm : Form
    {

        private List<Resource> resources = new List<Resource>();

        private static string dateFormat = "dd.MM.yyyy";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            NewResourceForm addForm = new NewResourceForm();
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK)
            {
                Resource res = addForm.GetResource();
                resources.Add(res);
                dgwResources.Rows.Add(new object[] { res.ID, res.Name, res.Discovered.ToString(dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable });
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
                dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }

        private void btnEditResource_Click(object sender, EventArgs e)
        {
            if (dgwResources.SelectedRows.Count > 0)
            {
                EditResourceForm erf = new EditResourceForm((Resource)dgwResources.SelectedRows[0].Tag);
                erf.ShowDialog();

                if (erf.DialogResult == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgwResources.SelectedRows)
                    {
                        if (row.Selected)
                        {
                            Resource res = erf.GetResource();
                            int index = dgwResources.Rows.IndexOf(row);
                            dgwResources.Rows.RemoveAt(index);
                            dgwResources.Rows.Insert(index, new object[] { res.ID, res.Name, res.Discovered.ToString(dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable });
                            dgwResources.Rows[index].Tag = res;
                            break;
                        }
                    }
                    dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
                }
            }
        }

        private void dgwResources_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwResources.SelectedRows.Count == 0)
            {
                txtId.Text = "";
                txtFrequency.Text = "";
                txtName.Text = "";
                txtUnit.Text = "";
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
                }
            }
        }

        private void btnEditResource_Click_1(object sender, EventArgs e)
        {
            btnEditResource_Click(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgwResources.Rows.Clear();
            foreach (Resource res in resources)
            {
                dgwResources.Rows.Add(new object[] { res.ID, res.Name, res.Discovered.ToString(dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable });
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
            }
            if (dgwResources.Rows.Count > 0)
            {
                dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }
    }
}
