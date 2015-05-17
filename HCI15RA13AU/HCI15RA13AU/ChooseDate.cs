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
    public partial class ChooseDate : Form
    {
        public ChooseDate()
        {
            InitializeComponent();
        }

        public ChooseDate(ApproxDate approxDate)
        {
            InitializeComponent();

            if (approxDate == null)
                return;

            if (approxDate.Unknown)
            {
                rbtUnknown.Checked = true;
            }
            else if (approxDate.Year >= 0)
            {
                rbtYear.Checked = true;
                txtYear.Text = approxDate.Year.ToString();
                chbYear.Checked = !approxDate.AD;
            }
            else if (approxDate.Century >= 0)
            {
                rbtCentury.Checked = true;
                txtCentury.Text = approxDate.Century.ToString();
                chbCentury.Checked = !approxDate.AD;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (rbtYear.Checked)
            {
                // error cheching
            }
            else
            {
                epDate.SetError(txtYear, "");
            }
        }

        private void txtCentury_Validating(object sender, CancelEventArgs e)
        {
            if (rbtCentury.Checked)
            {
                // error cheching
            }
            else
            {
                epDate.SetError(txtCentury, "");
            }
        }

        public ApproxDate getApproxDate()
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
    }
}
