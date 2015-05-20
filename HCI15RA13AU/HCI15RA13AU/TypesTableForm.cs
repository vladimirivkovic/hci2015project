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
    public partial class TypesTableForm : Form
    {
        private Type selectedType = null;
        private bool selection = false; 

        public TypesTableForm()
        {
            InitializeComponent();
            btnSelect.Hide();
        }

        public TypesTableForm(bool selection)
        {
            InitializeComponent();
            this.selection = selection;
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            TypeForm tf;
            tf = new TypeForm();
            tf.ShowDialog();

            if (tf.DialogResult == DialogResult.OK)
            {
                Type t = tf.GetResourceType();
                MainForm.types.Add(t.ID, t);
                dgwTypes.Rows.Add(new object[] { t.ID, t.Name });
                dgwTypes.Rows[dgwTypes.Rows.Count - 1].Tag = t;
                dgwTypes.CurrentCell = dgwTypes.Rows[dgwTypes.Rows.Count - 1].Cells[0];
            }
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            if (dgwTypes.SelectedRows.Count > 0 && !selection)
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
                            dgwTypes.Rows.Insert(index, new object[] { t.ID, t.Name });
                            dgwTypes.Rows[index].Tag = t;
                            dgwTypes.CurrentCell = dgwTypes.Rows[index].Cells[0];
                            MainForm.types.Remove(t.ID);
                            MainForm.types.Add(t.ID, t);
                            break;
                        }
                    }
                }
            }
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (dgwTypes.SelectedRows.Count == 0 || selection)
                return;
            DataGridViewRow row = dgwTypes.SelectedRows[0];
            if (row != null)
            {
                int index = dgwTypes.Rows.IndexOf(row);
                Type t = (Type)row.Tag;
                if (t != null)
                {
                    List<Resource> deleted = new List<Resource>();
                    List<DataGridViewRow> rows = new List<DataGridViewRow>();
                    foreach (Resource res in MainForm.resources.Values)
                    {
                        if (res.Type.ID == t.ID)
                        {
                            deleted.Add(res);
                            //foreach (DataGridViewRow r in dgwResources.Rows)
                            //{
                            //    if (((Resource)r.Tag).ID == res.ID)
                            //    {
                            //        rows.Add(r);
                            //    }
                            //}
                        }
                    }
                    if (deleted.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder("Brisanjem tipa biće obrisani i sledeci resursi toga tipa:\n");
                        foreach (Resource res in deleted)
                        {
                            sb.AppendLine(res.ID);
                        }
                        sb.AppendLine("Da li želite da nastavite sa brisanjem?");
                        DialogResult result = MessageBox.Show(sb.ToString(),
                            "Brisanje tipa resursa", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    //foreach (Resource id in deleted)
                    //{
                    //    resources.Remove(id.ID);
                    //}
                    //foreach (DataGridViewRow i in rows)
                    //{
                    //    dgwResources.Rows.Remove(i);
                    //}
                    MainForm.types.Remove(t.ID);
                }
                dgwTypes.Rows.RemoveAt(index);
            }
        }

        private void dgwTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwTypes.SelectedRows.Count == 0)
            {
                txtTypeDesc.Text = "";
                pbxTypeIcon.Image = null;
            }
            else
            {
                Type t = (Type)dgwTypes.SelectedRows[0].Tag;
                if (t != null)
                {
                    txtTypeDesc.Text = t.Description;
                    if (!t.IconFileName.Equals(""))
                    {
                        try
                        {
                            pbxTypeIcon.Image = Image.FromFile(t.IconFileName);
                            pbxTypeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (FileNotFoundException e1)
                        {
                            pbxTypeIcon.Image = pbxTypeIcon.ErrorImage;
                            Console.WriteLine(e1.StackTrace);
                        }
                    }
                    else
                    {
                        pbxTypeIcon.Image = pbxTypeIcon.InitialImage; ;
                    }
                }
            }
        }

        private void TypesTable_Load(object sender, EventArgs e)
        {
            dgwTypes.Rows.Clear();
            foreach (Type t in MainForm.types.Values)
            {
                dgwTypes.Rows.Add(new object[] { t.ID, t.Name });
                dgwTypes.Rows[dgwTypes.Rows.Count - 1].Tag = t;
            }
            if (dgwTypes.Rows.Count > 0)
            {
                dgwTypes.CurrentCell = dgwTypes.Rows[0].Cells[0];
                dgwTypes_SelectionChanged(dgwTypes, EventArgs.Empty);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgwTypes.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = dgwTypes.SelectedRows[0];
            selectedType = (Type) row.Tag;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Type GetType()
        {
            return selectedType;
        }
    }
}
