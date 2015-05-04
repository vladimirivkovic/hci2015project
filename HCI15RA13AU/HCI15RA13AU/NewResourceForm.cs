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
    public partial class NewResourceForm : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        private bool formIsValid = true;
        private Dictionary<string, Tag> tags;
        private Type type;
        private string fullFileName = "";
        private string fname = "";

        public NewResourceForm()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            this.cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Type t in MainForm.types.Values)
            {
                cmbType.Items.Add(t.ID);
            }
            tags = new Dictionary<string, Tag>();
            type = new Type();
            type.ID = "";
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                fullFileName = ofd.FileName;
                fname = ofd.SafeFileName;
                lblIconName.Text = fname;
            }
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (txtId.Text.Length == 0)
            {
                formIsValid = false;
                epAdd.SetError(txtId, "Unos oznake je obavezan");
            }
            else if (MainForm.resources.ContainsKey(txtId.Text))
            {
                formIsValid = false;
                epAdd.SetError(txtId, "Resurs sa ovom oznakom već postoji");
            }
            else
            {
                epAdd.SetError(txtId, "");
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                formIsValid = false;
                epAdd.SetError(txtName, "Unos naziva je obavezan");
            }
            else
            {
                epAdd.SetError(txtName, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            epAdd.SetError(txtDescription, "");
            //if (txtDescription.Text.Length == 0)
            //{
            //    formIsValid = false;
            //    epAdd.SetError(txtDescription, "Unos naziva je obavezan");
            //}
            //else
            //{
            //    epAdd.SetError(txtDescription, "");
            //}
        }

        private void rbtUniversal_Validating(object sender, CancelEventArgs e)
        {
            if (!(rbtFrequent.Checked || rbtRare.Checked || rbtUniversal.Checked))
            {
                formIsValid = false;
                epAdd.SetError(rbtUniversal, "Odabir frekvencije je obavezan");
            }
            else
            {
                epAdd.SetError(rbtUniversal, "");
            }
        }

        private void rbtRare_Validating(object sender, CancelEventArgs e)
        {
            rbtUniversal_Validating(sender, e);
        }


        private void rbtFrequent_Validating(object sender, CancelEventArgs e)
        {
            rbtUniversal_Validating(sender, e);
        }

        private void cmbUnit_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUnit.SelectedItem == null)
            {
                formIsValid = false;
                epAdd.SetError(cmbUnit, "Odabir jedinice mere je obavezan");
            }
            else
            {
                epAdd.SetError(cmbUnit, "");
            }
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            double cost;
            if (txtCost.Text.Length == 0)
            {
                formIsValid = false;
                epAdd.SetError(txtCost, "Unos cene je obavezan");
            }
            else if (double.TryParse(txtCost.Text, out cost))
            {
                if (cost < 0)
                {
                    formIsValid = false;
                    epAdd.SetError(txtCost, "Cena mora da bude pozitivna");
                }
                else
                {
                    epAdd.SetError(txtCost, "");
                }
            }
            else
            {
                epAdd.SetError(txtCost, "Cena mora da bude broj");
            }
        }

        public Resource GetResource()
        {
            Resource res = new Resource();
            res.ID = txtId.Text;
            res.Name = txtName.Text;
            res.Description = txtDescription.Text;
            res.Important = chbImportant.Checked;
            res.Renewable = chbRenewable.Checked;
            res.Exploatable = chbExploatable.Checked;
            res.Unit = Resource.StringToUnit(cmbUnit.Text);
            if (rbtFrequent.Checked)
                res.Frequency = Frequency.FREQUENT;
            else if (rbtRare.Checked)
                res.Frequency = Frequency.RARE;
            else
                res.Frequency = Frequency.UNIVERSAL;
            res.Cost = double.Parse(txtCost.Text);
            res.Discovered = dateTimePicker.Value;
            res.Tags = tags;      
            res.Type = type;
            if (cmbType.SelectedItem != null)
            {
                string typeID = cmbType.SelectedItem.ToString();
                foreach (Type t in MainForm.types.Values)
                {
                    if (t.ID == typeID)
                    {
                        res.Type = t;
                    }
                }
            }
            try
            {
                File.Copy(fullFileName, "images\\" + fname);
            }
            catch
            {
                Console.WriteLine("File allready exists");
            }
            res.IconFileName = "images\\" + fname;

            return res;
        }

        private void dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker.Value.CompareTo(DateTime.Now) > 0)
            {
                formIsValid = false;
                epAdd.SetError(dateTimePicker, "Datum mora biti u prošlosti");
            }
            else
            {
                epAdd.SetError(dateTimePicker, "");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            formIsValid = true;
            this.ValidateChildren();
            if (formIsValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // TODO : error
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            SelectTagForm nt = new SelectTagForm(tags);
            nt.ShowDialog();

            if (nt.DialogResult == DialogResult.OK)
            {
                tags.Clear();
                List<string> ret = nt.GetSelectedTags();
                foreach(string s in ret) {
                    if (MainForm.tags.ContainsKey(s))
                    {
                        Tag t = MainForm.tags[s];
                        tags.Add(s, t);
                    }
                }
                lblTag.Text = tags.Count.ToString() + " etiketa";
            }
        }

        private void cmbType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                formIsValid = false;
                epAdd.SetError(cmbType, "Izbor tipa je neophodan");
            }
            else
            {
                epAdd.SetError(cmbType, "");
            }
        }
    }
}
