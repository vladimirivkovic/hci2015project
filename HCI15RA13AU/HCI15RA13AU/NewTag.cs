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

        public TagForm()
        {
            InitializeComponent();
            txtColor.BackColor = color;
        }

        public TagForm(Tag t)
        {
            InitializeComponent();
            txtId.Text = t.ID;
            txtDescription.Text = t.Description;
            txtColor.BackColor = t.Color;
            color = txtColor.BackColor;
        }

        public Tag GetTag()
        {
            Tag t = new Tag();
            t.Color = color;
            t.Description = txtDescription.Text;
            t.ID = txtId.Text;
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
            else
            {
                epTag.SetError(txtId, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text.Length == 0)
            {
                formIsValid = false;
                epTag.SetError(txtDescription, "Unos naziva je obavezan");
            }
            else
            {
                epTag.SetError(txtDescription, "");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            formIsValid = true;
            this.ValidateChildren();
            if (formIsValid)
            {
                MainForm.tags.Add(GetTag());
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
    }
}
