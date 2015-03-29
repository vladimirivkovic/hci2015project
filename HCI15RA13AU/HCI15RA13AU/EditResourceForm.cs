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
    public partial class EditResourceForm : Form
    {

        private OpenFileDialog ofd = new OpenFileDialog();
        private bool formIsValid = true;
        private List<Tag> tags;

        public EditResourceForm(Resource res)
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            this.cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;

            tags = res.Tags;

            txtId.Text = res.ID;
            txtId.ReadOnly = true;
            txtName.Text = res.Name;
            txtDescription.Text = res.Description;
            lblIconName.Text = res.IconFileName;
            if (res.Renewable)
                chbRenewable.Checked = true;
            if (res.Important)
                chbImportant.Checked = true;
            if (res.Accessable)
                chbExploatable.Checked = true;
            cmbUnit.Text = Resource.UnitToString(res.Unit);
            switch (res.Frequency)
            {
                case Frequency.FREQUENT:
                    rbtFrequent.Checked = true;
                    break;
                case Frequency.RARE:
                    rbtRare.Checked = true;
                    break;
                case Frequency.UNIVERSAL:
                    rbtUniversal.Checked = true;
                    break;
            }
            txtCost.Text = res.Cost.ToString();
            dateTimePicker.Value = res.Discovered;
            lblTag.Text = res.Tags.Count.ToString();
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

        public Resource GetResource()
        {
            Resource res = new Resource();
            res.ID = txtId.Text;
            res.Name = txtName.Text;
            res.Description = txtDescription.Text;
            res.Important = chbImportant.Checked;
            res.Renewable = chbRenewable.Checked;
            res.Accessable = chbExploatable.Checked;
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

            return res;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                formIsValid = false;
                epEdit.SetError(txtName, "Unos naziva je obavezan");
            }
            else
            {
                epEdit.SetError(txtName, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text.Length == 0)
            {
                formIsValid = false;
                epEdit.SetError(txtDescription, "Unos naziva je obavezan");
            }
            else
            {
                epEdit.SetError(txtDescription, "");
            }
        }

        private void rbtUniversal_Validating(object sender, CancelEventArgs e)
        {
            if (!(rbtFrequent.Checked || rbtRare.Checked || rbtUniversal.Checked))
            {
                formIsValid = false;
                epEdit.SetError(rbtUniversal, "Odabir frekvencije je obavezan");
            }
            else
            {
                epEdit.SetError(rbtUniversal, "");
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
                epEdit.SetError(cmbUnit, "Odabir jedinice mere je obavezan");
            }
            else
            {
                epEdit.SetError(cmbUnit, "");
            }
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            double cost;
            if (txtCost.Text.Length == 0)
            {
                formIsValid = false;
                epEdit.SetError(txtCost, "Unos cene je obavezan");
            }
            else if (double.TryParse(txtCost.Text, out cost))
            {
                if (cost < 0)
                {
                    formIsValid = false;
                    epEdit.SetError(txtCost, "Cena mora da bude pozitivna");
                }
                else
                {
                    epEdit.SetError(txtCost, "");
                }
            }
            else
            {
                epEdit.SetError(txtCost, "Cena mora da bude broj");
            }
        }

        private void dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker.Value.CompareTo(DateTime.Now) > 0)
            {
                formIsValid = false;
                epEdit.SetError(dateTimePicker, "Datum mora biti u prošlosti");
            }
            else
            {
                epEdit.SetError(dateTimePicker, "");
            }
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            NewTag nt = new NewTag();
            nt.ShowDialog();

            if (nt.DialogResult == DialogResult.OK)
            {
                tags.Add(nt.GetTag());
                lblTag.Text = tags.Count.ToString();
            }
        }

    }
}
