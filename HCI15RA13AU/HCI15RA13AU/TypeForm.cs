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
    public partial class TypeForm : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        private bool formIsValid;
        private Type type;
        private bool edit = false;
        private string ID;

        public TypeForm()
        {
            InitializeComponent();
        }

        public TypeForm(Type type)
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            this.type = new Type();
            this.type = type;
            txtId.Text = type.SecondID;
            txtName.Text = type.Name;
            txtDescription.Text = type.Description;
            if (type.IconFileName != null)
                lblIconName.Text = type.IconFileName;
            else
                lblIconName.Text = "";

            ID = type.ID;
            edit = true;
            this.Text = "Izmena tipa resursa";
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (txtId.Text.Length == 0)
            {
                formIsValid = false;
                epType.SetError(txtId, "Unos oznake je obavezan");
            }
            else if (txtId.Text.Contains(" "))
            {
                formIsValid = false;
                epType.SetError(txtId, "Oznaka ne sme sadrzavati razmake");
            }
            else
            {
                Type t = MainForm.GetTypeBySecondID(txtId.Text);
                if (t != null && !edit)
                {
                    formIsValid = false;
                    epType.SetError(txtId, "Tip sa ovom oznakom već postoji");
                }
                else if (t != null && edit && !t.ID.Equals(ID))
                {
                    formIsValid = false;
                    epType.SetError(txtId, "Tip sa ovom oznakom već postoji");
                }
                else
                {
                    epType.SetError(txtId, "");
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                formIsValid = false;
                epType.SetError(txtName, "Unos naziva je obavezan");
            }
            else
            {
                epType.SetError(txtName, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            //if (txtDescription.Text.Length == 0)
            //{
            //    formIsValid = false;
            //    epType.SetError(txtDescription, "Unos naziva je obavezan");
            //}
            //else
            //{
                epType.SetError(txtDescription, "");
            //}
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

        public Type GetResourceType()
        {
            Type t = new Type();

            int i = 0;
            t.ID = edit ? ID : txtId.Text;
            if (!edit && MainForm.types.ContainsKey(t.ID))
            {
                do { i++; } while (!edit && MainForm.types.ContainsKey(t.ID + i));
                t.ID += i++;
            }
            t.SecondID = txtId.Text;
            t.Name = txtName.Text;
            t.Description = txtDescription.Text;
            if (lblIconName.Text != null)
            {
                t.IconFileName = lblIconName.Text;
            }
            else
            {
                t.IconFileName = "";
            }

            return t;
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                try
                {
                    File.Copy(fname, "..\\..\\images\\" + ofd.SafeFileName);
                    
                }
                catch
                {
                    Console.WriteLine("File allready exists");
                }
                fname = "..\\..\\images\\" + ofd.SafeFileName;
                lblIconName.Text = fname;
            }
        }
    }
}
