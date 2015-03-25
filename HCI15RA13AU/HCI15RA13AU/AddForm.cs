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
    public partial class AddForm : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        private bool formIsValid = true;

        public AddForm()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            this.cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                lblIconName.Text = fname;
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
            }
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (txtId.Text.Length == 0)
            {
                formIsValid = false;
                epAdd.SetError(txtId, "Unos oznake je obavezan");
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
            if (txtDescription.Text.Length == 0)
            {
                formIsValid = false;
                epAdd.SetError(txtDescription, "Unos naziva je obavezan");
            }
            else
            {
                epAdd.SetError(txtDescription, "");
            }
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
    }
}
