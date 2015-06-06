using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HCI15RA13AU
{
    public partial class ResourcesFilterForm : Form
    {
        private double minCost;
        private double maxCost;

        private List<string> tags = new List<string>();

        private List<Resource> resources;

        private bool formIsValid = true;

        private Regex rxCentury;
        private Regex rxYear;

        private ApproxDate approxDateMin;
        private ApproxDate approxDateMax;

        public ResourcesFilterForm()
        {
            InitializeComponent();

            resources = MainForm.resources.Values.ToList();

            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFrequency.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Type t in MainForm.types.Values)
            {
                cmbType.Items.Add(t.SecondID);
            }

            chbID_CheckedChanged(this, EventArgs.Empty);
            chbName_CheckedChanged(this, EventArgs.Empty);
            chbDate_CheckedChanged(this, EventArgs.Empty);
            chbImportant_CheckedChanged(this, EventArgs.Empty);
            chbRenewable_CheckedChanged(this, EventArgs.Empty);
            chbUnit_CheckedChanged(this, EventArgs.Empty);
            chbFrequency_CheckedChanged(this, EventArgs.Empty);
            chbCost_CheckedChanged(this, EventArgs.Empty);
            chbType_CheckedChanged(this, EventArgs.Empty);
            chbTags_CheckedChanged(this, EventArgs.Empty);

            rbtDateMin1.Checked = true;
            rbtDateMax1.Checked = true;
            rbtDateMin1_CheckedChanged(this, EventArgs.Empty);
            rbtDateMin1_CheckedChanged(this, EventArgs.Empty);

            rxCentury = new Regex("^[1-9][0-9]*\\.vek[ ](p\\.)?n\\.e\\.$");
            rxYear = new Regex("^[1-9][0-9]*\\.g\\.[ ](p\\.)?n\\.e\\.$");

            approxDateMax = new ApproxDate();
            approxDateMin = new ApproxDate();
        }

        private void chbID_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = chbID.Checked;
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = chbName.Checked;
        }

        private void chbDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpMin.Enabled = chbDate.Checked;
            dtpMax.Enabled = chbDate.Checked;
            panel1.Enabled = chbDate.Checked; ;
            panel2.Enabled = chbDate.Checked;
            rbtDateMin1.Enabled = chbDate.Checked;
            rbtDateMin2.Enabled = chbDate.Checked;
            rbtDateMax1.Enabled = chbDate.Checked;
            rbtDateMax2.Enabled = chbDate.Checked;
        }

        private void chbImportant_CheckedChanged(object sender, EventArgs e)
        {
            chbIsImportant.Enabled = chbImportant.Checked;
        }

        private void chbRenewable_CheckedChanged(object sender, EventArgs e)
        {
            chbIsRenewable.Enabled = chbRenewable.Checked;
        }

        private void chbFrequency_CheckedChanged(object sender, EventArgs e)
        {
            cmbFrequency.Enabled = chbFrequency.Checked;
        }

        private void chbUnit_CheckedChanged(object sender, EventArgs e)
        {
            cmbUnit.Enabled = chbUnit.Checked;
        }

        private void chbCost_CheckedChanged(object sender, EventArgs e)
        {
            txtCostMin.Enabled = chbCost.Checked;
            txtCostMax.Enabled = chbCost.Checked;
        }

        private void ResourcesFilter_Load(object sender, EventArgs e)
        {
            string date;

            dgwResources.Rows.Clear();
            foreach (Resource res in MainForm.resources.Values)
            {
                date = res.Discovered.ToString(MainForm.dateFormat);

                if (res.ApproxDiscovered != null)
                {
                    date = res.ApproxDiscovered.ToString();
                }

                dgwResources.Rows.Add(new object[] { res.SecondID, res.Name, 
                    date, res.Cost.ToString("C"), res.Important, res.Renewable,
                    Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
            }
            if (dgwResources.Rows.Count > 0)
            {
                dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }

        private void dgwResources_SelectionChanged(object sender, EventArgs e)
        {
            // TODO : to implement
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            formIsValid = true;
            this.ValidateChildren();

            if (!formIsValid)
                return;

            string date;

            double.TryParse(txtCostMin.Text, out minCost);
            double.TryParse(txtCostMax.Text, out maxCost);

            resources.Clear();
            IEnumerable<Resource> result1 = from res in MainForm.resources.Values
                                           where ((!txtID.Enabled || txtID.Text.Equals(res.SecondID))
                                                && (!txtName.Enabled || txtName.Text.Equals(res.Name))
                                                && (!chbIsImportant.Enabled || chbIsImportant.Checked == res.Important)
                                                && (!chbIsRenewable.Enabled || chbIsRenewable.Checked == res.Renewable)
                                                && (!cmbFrequency.Enabled 
                                                    || (cmbFrequency.SelectedItem != null 
                                                    && cmbFrequency.SelectedItem.Equals(Resource.FrequencyToString(res.Frequency))))
                                                && (!cmbUnit.Enabled 
                                                    || (cmbUnit.SelectedItem != null 
                                                    && cmbUnit.SelectedItem.Equals(Resource.UnitToString(res.Unit))))
                                                && (!txtCostMax.Enabled || (minCost <= res.Cost && res.Cost <= maxCost))
                                                && (!cmbType.Enabled 
                                                    || (cmbType.SelectedItem != null 
                                                    && cmbType.SelectedItem.Equals(res.Type.SecondID)))
                                                //&& (!dtpMax.Enabled 
                                                //    || (dtpMax.Value.CompareTo(res.Discovered) >= 0 
                                                //    && dtpMin.Value.CompareTo(res.Discovered) <= 0
                                                //    && res.ApproxDiscovered == null)))
                                                )
                                                // exploation
                                            select res;
            dgwResources.Rows.Clear();

            if (chbTags.Checked)
            {
                bool contains;
                foreach (Resource res in result1)
                {
                    contains = true;
                    foreach (string tagId in tags)
                    {
                        if (!res.Tags.ContainsKey(tagId))
                        {
                            contains = false;
                        }
                    }
                    if (contains)
                    {
                        resources.Add(res);
                    }
                }
            }
            else
            {
                resources = result1.ToList();
            }

            if (chbDate.Checked)
            {
                for (int i = 0; i < resources.Count; i++)
                {
                    if (rbtDateMax1.Checked)
                    {
                        if (resources[i].ApproxDiscovered == null)
                        {
                            if (dtpMax.Value.CompareTo(resources[i].Discovered) < 0)
                            {
                                resources.RemoveAt(i);
                                i--;
                                continue;
                            }
                        }
                        else
                        {
                            if (resources[i].ApproxDiscovered.GetMinYear() > dtpMax.Value.Year)
                            {
                                resources.RemoveAt(i);
                                i--;
                                continue;
                            }
                        }
                    }
                    else
                    {
                        if (resources[i].ApproxDiscovered == null)
                        {
                            if (resources[i].Discovered.Year > approxDateMax.GetMaxYear())
                            {
                                resources.RemoveAt(i);
                                i--;
                                continue;
                            }
                        }
                        else
                        {
                            if (resources[i].ApproxDiscovered.GetMinYear() > approxDateMax.GetMaxYear())
                            {
                                resources.RemoveAt(i);
                                i--;
                                continue;
                            }
                        }
                    }

                    if (rbtDateMin1.Checked)
                    {
                        if (resources[i].ApproxDiscovered == null)
                        {
                            if(dtpMin.Value.CompareTo(resources[i].Discovered) > 0)
                            {
                                resources.RemoveAt(i);
                                i--;
                                continue;
                            }
                        }
                        else
                        {
                            if (resources[i].ApproxDiscovered.GetMaxYear() < dtpMin.Value.Year)
                            {
                                resources.RemoveAt(i);
                                i--;
                                continue;
                            }
                        }
                    }
                    else
                    {
                        if (resources[i].ApproxDiscovered == null)
                        {
                            if (resources[i].Discovered.Year < approxDateMin.GetMinYear())
                            {
                                resources.RemoveAt(i);
                                i--;
                                continue;
                            }
                        }
                        else
                        {
                            if (resources[i].ApproxDiscovered.GetMaxYear() < approxDateMin.GetMaxYear())
                            {
                                resources.RemoveAt(i);
                                i--;
                                continue;
                            }
                        }
                    }
                }
            }

            foreach (Resource res in resources)
            {
                date = res.Discovered.ToString(MainForm.dateFormat);

                if (res.ApproxDiscovered != null)
                {
                    date = res.ApproxDiscovered.ToString();
                }
                dgwResources.Rows.Add(new object[] { res.SecondID, res.Name, 
                    date, res.Cost.ToString("C"), res.Important, res.Renewable,
                    Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
            }
            if (dgwResources.Rows.Count > 0)
            {
                dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
                dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
            }
        }

        private void chbType_CheckedChanged(object sender, EventArgs e)
        {
            cmbType.Enabled = chbType.Checked;
        }

        private void chbTags_CheckedChanged(object sender, EventArgs e)
        {
            btnTags.Enabled = chbTags.Checked;
            if (!chbTags.Checked)
            {
                pnlTags.Hide();
            }
            else
            {
                pnlTags.Show();
            }
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            SelectTagForm stf = new SelectTagForm();
            stf.ShowDialog();

            if (stf.DialogResult == DialogResult.OK)
            {
                tags = stf.GetSelectedTags();

                int off = 0;
                Label lbl;
                pnlTags.Controls.Clear();
                foreach (string t in tags)
                {
                    lbl = new Label();
                    //lbl.Width = 5*t.Length;
                    lbl.Top = off;
                    lbl.Text = MainForm.tags[t].SecondID;
                    lbl.BackColor = MainForm.tags[t].Color;
                    //lbl.Left = off;
                    pnlTags.Controls.Add(lbl);
                    //lbl.Left = off;
                    off += lbl.Height;
                }

                pnlTags.Refresh();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnFilter_Click(this, EventArgs.Empty);
            formIsValid = true;
            this.ValidateChildren();

            if (!formIsValid)
                return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public List<Resource> GetResources()
        {
            return resources;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rbtDateMin1_CheckedChanged(object sender, EventArgs e)
        {
            dtpMin.Enabled = rbtDateMin1.Checked;
            txtDateMin.Enabled = !rbtDateMin1.Checked;
        }

        private void rbtDateMin2_CheckedChanged(object sender, EventArgs e)
        {
            dtpMin.Enabled = !rbtDateMin2.Checked;
            txtDateMin.Enabled = rbtDateMin2.Checked;
        }

        private void rbtDateMax1_CheckedChanged(object sender, EventArgs e)
        {
            dtpMax.Enabled = rbtDateMax1.Checked;
            txtDateMax.Enabled = !rbtDateMax1.Checked;
        }

        private void rbtDateMax2_CheckedChanged(object sender, EventArgs e)
        {
            dtpMax.Enabled = !rbtDateMax2.Checked;
            txtDateMax.Enabled = rbtDateMax2.Checked;
        }

        private void txtDateMin_Validating(object sender, CancelEventArgs e)
        {
            if (rbtDateMin2.Checked && chbDate.Checked)
            {
                if (rxCentury.Match(txtDateMin.Text).Success)
                {
                    epDate.SetError(txtDateMin, "");
                    formIsValid = true;

                    String[] tokens = txtDateMin.Text.Split(new char[] {'.'});
                    approxDateMin.Century = int.Parse(tokens[0]);
                    approxDateMin.AD = tokens[2][0] == 'e';
                    approxDateMin.Year = -1;
                    approxDateMin.Unknown = false;
                }
                else if (rxYear.Match(txtDateMin.Text).Success)
                {
                    epDate.SetError(txtDateMin, "");
                    formIsValid = true;

                    String[] tokens = txtDateMin.Text.Split(new char[] { '.' });
                    approxDateMin.Year = int.Parse(tokens[0]);
                    approxDateMin.AD = tokens[3][0] == 'e';
                    approxDateMin.Century = -1;
                    approxDateMin.Unknown = false;
                }
                else
                {
                    epDate.SetError(txtDateMin, "Nije dobro formatiran datum,\nprimer za vek: \"1.vek p.n.e\" \nprimer za godinu: \"1123.g. n.e.\"");
                    formIsValid = false;
                }
            }
            else
            {
                epDate.SetError(txtDateMin, "");
                formIsValid = true;
            }
        }

        private void txtDateMax_Validating(object sender, CancelEventArgs e)
        {
            if (rbtDateMax2.Checked && chbDate.Checked)
            {
                if (rxCentury.Match(txtDateMax.Text).Success)
                {
                    epDate.SetError(txtDateMax, "");
                    formIsValid = true;

                    String[] tokens = txtDateMax.Text.Split(new char[] { '.' });
                    approxDateMax.Century = int.Parse(tokens[0]);
                    approxDateMax.AD = tokens[2][0] == 'e';
                    approxDateMax.Year = -1;
                    approxDateMax.Unknown = false;
                }
                else if (rxYear.Match(txtDateMax.Text).Success)
                {
                    epDate.SetError(txtDateMax, "");
                    formIsValid = true;

                    String[] tokens = txtDateMax.Text.Split(new char[] { '.' });
                    approxDateMax.Year = int.Parse(tokens[0]);
                    approxDateMax.AD = tokens[3][0] == 'e';
                    approxDateMax.Century = -1;
                    approxDateMax.Unknown = false;
                }
                else
                {
                    epDate.SetError(txtDateMax, "Nije dobro formatiran datum,\nprimer za vek: \"1.vek p.n.e\" \nprimer za godinu: \"1123.g. n.e.\"");
                    formIsValid = false;
                }
            }
            else
            {
                epDate.SetError(txtDateMax, "");
                formIsValid = true;
            }
        }
    }
}
