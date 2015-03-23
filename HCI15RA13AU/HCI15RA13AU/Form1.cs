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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOil_Click(object sender, EventArgs e)
        {
            lblSelectedResource.Text = "Oil";
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            lblSelectedResource.Text = "Gas";
        }

        private void picEarth_Click(object sender, EventArgs e)
        {
            PictureBox pcb = new PictureBox();
            pcb.ImageLocation = @"E:\fax\hci2015project\images\pipe-line-icon.png";
            pcb.Location = new Point(0, 0);
        }
    }
}
