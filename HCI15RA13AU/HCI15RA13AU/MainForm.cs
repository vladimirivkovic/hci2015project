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

        public static List<Type> types = new List<Type>();

        public static List<Tag> tags = new List<Tag>();

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
                dgwResources.Rows.Add(new object[] { res.ID, res.Name, res.Discovered.ToString(dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable, Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit) });
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
                            dgwResources.Rows.Insert(index, new object[] { res.ID, res.Name, res.Discovered.ToString(dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable, Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit) });
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
                chbExploatable.Checked = false;
                chbImportant.Checked = false;
                chbRenewable.Checked = false;
                txtDescription.Text = "";
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

        private void btnNewType_Click(object sender, EventArgs e)
        {
            TypeForm tf;
            tf = new TypeForm();
            tf.ShowDialog();

            if (tf.DialogResult == DialogResult.OK)
            {
                Type t = tf.GetResourceType();
                types.Add(t);
                dgwTypes.Rows.Add(new object[] { t.ID, t.Name} );
                dgwTypes.Rows[dgwTypes.Rows.Count - 1].Tag = t;
                dgwTypes.CurrentCell = dgwTypes.Rows[0].Cells[0];
            }
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            if (dgwTypes.SelectedRows.Count > 0)
            {
                TypeForm tf = new TypeForm((Type)dgwTypes.SelectedRows[0].Tag);
                tf.ShowDialog();

                if (tf.DialogResult == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgwTypes.SelectedRows)
                    {
                        if (row.Selected)
                        {
                            Type t = tf.GetResourceType();
                            int index = dgwTypes.Rows.IndexOf(row);
                            dgwTypes.Rows.RemoveAt(index);
                            dgwTypes.Rows.Insert(index, new object[] { t.ID, t.Name});
                            dgwTypes.Rows[index].Tag = t;
                            break;
                        }
                    }
                }
            }
        }

        private void btnNewTag_Click(object sender, EventArgs e)
        {
            TagForm nt = new TagForm();
            nt.ShowDialog();

            if (nt.DialogResult == DialogResult.OK)
            {
                Tag t = nt.GetTag();
                tags.Add(t);
                dgwTags.Rows.Add(new object[] { t.ID, t.Color.ToString() });
                dgwTags.Rows[dgwTags.Rows.Count - 1].Tag = t;
                dgwTags.CurrentCell = dgwTags.Rows[0].Cells[0];
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
                            int index = dgwTags.Rows.IndexOf(row);
                            dgwTags.Rows.RemoveAt(index);
                            dgwTags.Rows.Insert(index, new object[] { t.ID, "" });
                            dgwTags.Rows[index].Tag = t;
                            break;
                        }
                    }
                }
            }
        }
    }
}
