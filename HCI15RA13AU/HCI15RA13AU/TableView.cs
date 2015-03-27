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
    public partial class TableView : Form
    {
        private List<Resource> resources;

        public TableView()
        {
            InitializeComponent();
            resources = new List<Resource>();
            dgwResources.Columns.Clear();
            dgwResources.Columns.Add("Id", "ID");
            dgwResources.Columns.Add("Name", "Naziv");
            dgwResources.Columns.Add("Date", "Datum");
            dgwResources.Columns.Add("Important", "Vaznost");
            dgwResources.Columns.Add("Cost", "Cena");
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
                    txtId.Text = res.Id;
                    txtFrequency.Text = Resource.FrequencyToString(res.Frequency);
                    txtName.Text = res.Name;
                    txtUnit.Text = Resource.UnitToString(res.Unit);
                }
            }
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            dgwResources.Rows.Clear();
            foreach(Resource res in resources)
            {
                dgwResources.Rows.Add(new object[] { res.Id, res.Name, res.Discovered.ToString(), res.Important.ToString() });
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
                resources.Add(res);
                dgwResources.Rows.Add(new object[] { res.Id, res.Name, res.Discovered.ToShortDateString(), res.Important.ToString(), res.Cost.ToString() });
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
                dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }

        private void btnEditResource_Click(object sender, EventArgs e)
        {
            if (dgwResources.SelectedRows.Count > 0)
            {
                EditResourceForm erf = new EditResourceForm((Resource) dgwResources.SelectedRows[0].Tag);
                erf.ShowDialog();

                if (erf.DialogResult == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgwResources.SelectedRows)
                    {
                        if (row.Selected)
                        {
                            row.Tag = erf.GetResource();
                            break;
                        }
                    }
                    dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
                }
            }
        }


    }
}
