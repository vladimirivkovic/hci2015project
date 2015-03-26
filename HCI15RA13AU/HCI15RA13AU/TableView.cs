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

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK)
            {
                Resource res = addForm.getResource();
                resources.Add(res);
                dgwResources.Rows.Add(new object[] { res.Id, res.Name, res.Discovered.ToShortDateString(), res.Important.ToString(), res.Cost.ToString() });
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
                dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }

        private void dgwResources_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwResources.SelectedRows.Count == 0)
            {
                txtName.Text = "";
            }
            else
            {
                Resource res = (Resource)dgwResources.SelectedRows[0].Tag;
                if (res != null)
                {
                    txtName.Text = res.Name;
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
    }
}
