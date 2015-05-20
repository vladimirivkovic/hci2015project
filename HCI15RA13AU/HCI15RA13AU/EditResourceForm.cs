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
    public partial class EditResourceForm : Form
    {

        private OpenFileDialog ofd = new OpenFileDialog();
        private bool formIsValid = true;
        private Dictionary<string, Tag> tags;
        private Type type;
        private string fullFileName = "";
        private string fname = "";
        private ApproxDate approxDate = null;

        public EditResourceForm(Resource res)
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            this.cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;

            tags = res.Tags;
            type = res.Type;

            txtId.Text = res.ID;
            txtId.ReadOnly = true;
            txtName.Text = res.Name;
            txtDescription.Text = res.Description;
            lblIconName.Text = res.IconFileName;
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
            lblTag.Text = res.Tags.Count.ToString();
            fullFileName = res.IconFileName;
            lblIconName.Text = fullFileName;
            if (res.ApproxDiscovered != null)
            {
                approxDate = res.ApproxDiscovered;
                lblApproxDate.Text = res.ApproxDiscovered.ToString();
            }
            

            foreach (Type t in MainForm.types.Values)
            {
                cmbType.Items.Add(t.ID);
            }
            cmbType.SelectedItem = res.Type.ID;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnDate, "Izbor okvirnog datuma");

            lblApproxDate.Enabled = rbtApproxDate.Checked;
            btnDate.Enabled = rbtApproxDate.Checked;
            dateTimePicker.Enabled = rbtDate.Checked;
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
            if (rbtDate.Checked)
            {
                res.Discovered = dateTimePicker.Value;
                res.ApproxDiscovered = null;
            }
            else
            {
                res.Discovered = DateTime.MaxValue;
                res.ApproxDiscovered = approxDate;
            }
            //res.Discovered = dateTimePicker.Value;
            //res.ApproxDiscovered = approxDate;
            res.Tags = tags;
            if (!fname.Equals(""))
            {
                try
                {
                    File.Copy(fullFileName, "..\\..\\images\\" + fname);
                }
                catch
                {
                    Console.WriteLine("File allready exists");
                }
                res.IconFileName = "..\\..\\images\\" + fname;
            }
            else
            {
                res.IconFileName = fullFileName;
            }
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

            return res;
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                fullFileName = ofd.FileName;
                fname = ofd.SafeFileName;
                lblIconName.Text = "..\\..\\images\\" + fname;
            }
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
            epEdit.SetError(txtDescription, "");
            //if (txtDescription.Text.Length == 0)
            //{
            //    formIsValid = false;
            //    epEdit.SetError(txtDescription, "Unos naziva je obavezan");
            //}
            //else
            //{
            //    epEdit.SetError(txtDescription, "");
            //}
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
            if (dateTimePicker.Value.CompareTo(DateTime.Now) > 0 && rbtDate.Checked)
            {
                formIsValid = false;
                epEdit.SetError(dateTimePicker, "Datum mora biti u prošlosti");
            }
            else
            {
                epEdit.SetError(dateTimePicker, "");
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
                foreach (string s in ret)
                {
                    if (MainForm.tags.ContainsKey(s))
                    {
                        Tag t = MainForm.tags[s];
                        tags.Add(s, t);
                    }
                }
                lblTag.Text = tags.Count.ToString() + " etiketa";
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            ChooseDate cd = new ChooseDate(approxDate);
            cd.ShowDialog();

            if (cd.DialogResult == DialogResult.OK)
            {
                approxDate = cd.getApproxDate();
                lblApproxDate.Text = approxDate.ToString();
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            approxDate = null;
            lblApproxDate.Text = "";
        }

        private void rbtApproxDate_CheckedChanged(object sender, EventArgs e)
        {
            lblApproxDate.Enabled = rbtApproxDate.Checked;
            btnDate.Enabled = rbtApproxDate.Checked;
        }

        private void rbtDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = rbtDate.Checked;
        }

        //private void btnType_Click(object sender, EventArgs e)
        //{
        //    TypeForm tf = new TypeForm(type);
        //    tf.ShowDialog();

        //    if (tf.DialogResult == DialogResult.OK)
        //    {
        //        type = tf.GetResourceType();
        //        btnType.Text = "Izmeni tip";
        //    }
        //}
    }
}
