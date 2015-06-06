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
    public partial class TagForm : Form
    {
        private bool formIsValid;
        private Color color = Color.White;
        private bool edit = false;
        private string ID;

        public TagForm()
        {
            InitializeComponent();
            txtColor.BackColor = color;
        }

        public TagForm(Tag t)
        {
            InitializeComponent();
            txtId.Text = t.SecondID;
            txtDescription.Text = t.Description;
            txtColor.BackColor = t.Color;
            color = txtColor.BackColor;

            ID = t.ID;
            edit = true;
            this.Text = "Izmena etikete";
        }

        public Tag GetTag()
        {
            Tag t = new Tag();
            t.Color = color;
            t.Description = txtDescription.Text;

            int i = 0;
            t.ID = edit ? ID : txtId.Text;
            if (!edit && MainForm.tags.ContainsKey(t.ID))
            {
                do { i++; } while (MainForm.tags.ContainsKey(t.ID + i));
                t.ID += i++;
            }

            t.SecondID = txtId.Text;
                
            return t;
        }

        

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            color = cd.Color;
            txtColor.BackColor = color;
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (txtId.Text.Length == 0)
            {
                formIsValid = false;
                epTag.SetError(txtId, "Unos oznake je obavezan");
            }
            else if (txtId.Text.Contains(" "))
            {
                formIsValid = false;
                epTag.SetError(txtId, "Oznaka ne sme sadrzavati razmake");
            }
            else
            {
                Tag t = MainForm.GetTagBySecondID(txtId.Text);
                if (t != null && !edit)
                {
                    formIsValid = false;
                    epTag.SetError(txtId, "Etiketa sa ovom oznakom već postoji");
                }
                else if (t != null && edit && !t.ID.Equals(ID))
                {
                    formIsValid = false;
                    epTag.SetError(txtId, "Etiketa sa ovom oznakom već postoji");
                }
                else
                {
                    epTag.SetError(txtId, "");
                }
            }
            lblStatus.Text = "";
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            //if (txtDescription.Text.Length == 0)
            //{
            //    formIsValid = false;
            //    epTag.SetError(txtDescription, "Unos naziva je obavezan");
            //}
            //else
            //{
                epTag.SetError(txtDescription, "");
                lblStatus.Text = "";
            //}
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            formIsValid = true;
            this.ValidateChildren();
            if (formIsValid)
            {
                //MainForm.tags.Add(GetTag());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblStatus.Text = "Polja označena crvenim znakom imaju neispravan sadržaj";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
