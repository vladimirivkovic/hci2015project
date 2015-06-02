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
        private Type type = null;
        private string fullFileName = "";
        private string fname = "";
        private int year;
        private int century;
        private bool edit = false;
        private string ID;

        public NewResourceForm()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            this.cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;

            tags = new Dictionary<string, Tag>();

            rbtUnknown.Checked = true;
            rbtDate.Checked = true;
            rbtDate_CheckedChanged(this, EventArgs.Empty);
            rbtApproxDate_CheckedChanged(this, EventArgs.Empty);

            this.MaximizeBox = false;
        }
                
        public NewResourceForm(Resource res)
        {
            InitializeComponent();
            this.Text = "Uredi podatke o resursu";
            edit = true;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            this.cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;

            tags = res.Tags;
            type = res.Type;

            ID = res.ID;

            txtId.Text = res.SecondID;
            txtName.Text = res.Name;
            txtDescription.Text = res.Description;
            lblIconName.Text = res.IconFileName;
            lblTypeID.Text = type.ID;
            if (res.Renewable)
                chbRenewable.Checked = true;
            if (res.Important)
                chbImportant.Checked = true;
            if (res.Exploatable)
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
            lblTag.Text = res.Tags.Count.ToString() + " etiketa";
            fullFileName = res.IconFileName;
            char[] sep = { '\\' };
            fname = lblIconName.Text = fullFileName.Split(sep).Last();
            if (res.ApproxDiscovered != null)
            {
                rbtApproxDate.Checked = true;
                // TODO : fill approxDate group box
                if (res.ApproxDiscovered.Unknown)
                {
                    rbtUnknown.Checked = true;
                }
                else if (res.ApproxDiscovered.Year >= 0)
                {
                    rbtYear.Checked = true;
                    txtYear.Text = res.ApproxDiscovered.Year.ToString();
                    chbYear.Checked = !res.ApproxDiscovered.AD;
                }
                else if (res.ApproxDiscovered.Century >= 0)
                {
                    rbtCentury.Checked = true;
                    txtCentury.Text = res.ApproxDiscovered.Century.ToString();
                    chbCentury.Checked = !res.ApproxDiscovered.AD;
                }
            }
            else
            {
                rbtUnknown.Checked = true;
                rbtDate.Checked = true;
            }

            
            
            rbtDate_CheckedChanged(this, EventArgs.Empty);
            rbtApproxDate_CheckedChanged(this, EventArgs.Empty);
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
            else if(txtId.Text.Contains(" "))
            {
                formIsValid = false;
                epAdd.SetError(txtId, "Oznaka ne može sadržavati razmake");
            }
            else
            {
                Resource res = MainForm.GetResourceBySecondID(txtId.Text);
                if (res != null && !edit)
                {
                    formIsValid = false;
                    epAdd.SetError(txtId, "Resurs sa ovom oznakom već postoji");
                }
                else if (res != null && edit && !res.ID.Equals(ID))
                {
                    formIsValid = false;
                    epAdd.SetError(txtId, "Resurs sa ovom oznakom već postoji");
                }
                else
                {
                    epAdd.SetError(txtId, "");
                }
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

            int i=0;
            res.ID = edit ? ID : txtId.Text;
            if (!edit && MainForm.resources.ContainsKey(res.ID))
            {
                do { i++; } while (MainForm.resources.ContainsKey(res.ID + i));
                res.ID += i++;
            }
            
            res.SecondID = txtId.Text;
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
            if (rbtDate.Checked)
            {
                res.Discovered = dateTimePicker.Value;
                res.ApproxDiscovered = null;
            }
            else
            {
                res.Discovered = dateTimePicker.Value;
                res.ApproxDiscovered = getApproxDate();
            }
            //res.Discovered = dateTimePicker.Value;
            //res.ApproxDiscovered = approxDate;
            res.Tags = tags;      
            res.Type = type;
            try
            {
                File.Copy(fullFileName, "..\\..\\images\\" + fname);
            }
            catch
            {
                Console.WriteLine("File allready exists");
            }
            res.IconFileName = "..\\..\\images\\" + fname;

            return res;
        }

        private void dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker.Value.CompareTo(DateTime.Now) > 0 && rbtDate.Checked)
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

        private void rbtDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = rbtDate.Checked;
        }

        private void rbtApproxDate_CheckedChanged(object sender, EventArgs e)
        {
            gbxApproxDate.Visible = rbtApproxDate.Checked;
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (rbtYear.Checked)
            {
                bool success = int.TryParse(txtYear.Text, out century);
                if (success)
                {
                    if (century <= 0)
                    {
                        formIsValid = false;
                        epAdd.SetError(txtYear, "Godina treba da bude pozitivan ceo broj");
                    }
                    else
                    {
                        epAdd.SetError(txtYear, "");
                    }
                }
                    // TODO : CHECK 22 CENTURY
                else
                {
                    formIsValid = false;
                    epAdd.SetError(txtYear, "Godina treba da bude pozitivan ceo broj");
                }
            }
            else
            {
                epAdd.SetError(txtYear, "");
            }
        }

        private void txtCentury_Validating(object sender, CancelEventArgs e)
        {
            if (rbtCentury.Checked)
            {
                bool success = int.TryParse(txtCentury.Text, out year);
                if (success)
                {
                    if (year <= 0)
                    {
                        formIsValid = false;
                        epAdd.SetError(txtCentury, "Vek treba da bude pozitivan ceo broj");
                    }
                        // TODO : CHECK 2222 YEAR
                    else
                    {
                        epAdd.SetError(txtCentury, "");
                    }
                }
                else
                {
                    formIsValid = false;
                    epAdd.SetError(txtCentury, "Vek treba da bude pozitivan ceo broj");
                }
            }
            else
            {
                epAdd.SetError(txtCentury, "");
            }
        }

        private void gbxDate_Validating(object sender, CancelEventArgs e)
        {
            if (rbtApproxDate.Checked || rbtDate.Checked)
            {
                epAdd.SetError(txtCentury, "");
            }
            else
            {
                formIsValid = false;
                epAdd.SetError(txtCentury, "Izbor datuma je obavezan");
            }
        }

        private ApproxDate getApproxDate()
        {
            int year = -1;
            int century = -1;
            bool unknown = false;
            bool ad = false;

            if (rbtYear.Checked)
            {
                year = int.Parse(txtYear.Text);
                ad = !chbYear.Checked;
            }
            else if (rbtCentury.Checked)
            {
                century = int.Parse(txtCentury.Text);
                ad = !chbCentury.Checked;
            }
            else
            {
                unknown = true;
            }

            return new ApproxDate(year, century, ad, unknown);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            TypesTableForm typesTable = new TypesTableForm(true);
            typesTable.ShowDialog();

            if (typesTable.DialogResult == DialogResult.OK)
            {
                type = typesTable.GetType();
                lblTypeID.Text = type.SecondID;
            }
        }

        private void btnType_Validating(object sender, CancelEventArgs e)
        {
            if (type != null)
            {
                epAdd.SetError(btnType, "");
            }
            else
            {
                epAdd.SetError(btnType, "Izbor tipa je obavezan");
            }
        }
    }
}
