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
    public partial class ResourcesFilter : Form
    {
        private double minCost;
        private double maxCost;

        public ResourcesFilter()
        {
            InitializeComponent();

            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFrequency.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Type t in MainForm.types.Values)
            {
                cmbType.Items.Add(t.ID);
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
            dgwResources.Rows.Clear();
            foreach (Resource res in MainForm.resources.Values)
            {
                dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
                    res.Discovered.ToString(MainForm.dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable,
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
            double.TryParse(txtCostMin.Text, out minCost);
            double.TryParse(txtCostMax.Text, out maxCost);

            IEnumerable<Resource> result = from res in MainForm.resources.Values
                                           where ((!txtID.Enabled || txtID.Text.Equals(res.ID))
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
                                                    && cmbType.SelectedItem.Equals(res.Type.ID)))
                                                && (!dtpMax.Enabled 
                                                    || (dtpMax.Value.CompareTo(res.Discovered) >= 0 
                                                    && dtpMin.Value.CompareTo(res.Discovered) <= 0)))
                                                // exploation
                                                // tags
                                            select res;
            dgwResources.Rows.Clear();
            foreach (Resource res in result)
            {
                dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
                    res.Discovered.ToString(MainForm.dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable,
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
    }
}
