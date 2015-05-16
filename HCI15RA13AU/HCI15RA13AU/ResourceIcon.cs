using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HCI15RA13AU
{
    public partial class ResourceIcon : UserControl
    {
        private Rectangle mouseDownSelectionWindow;
        private Point displayOffset;
        private ToolTip tt;

        public ResourceIcon()
        {
            InitializeComponent();
        }

        public ResourceIcon(Resource res)
        {
            InitializeComponent();

            try
            {
                pbxIcon.Image = Image.FromFile(res.IconFileName);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.StackTrace);
                pbxIcon.Image = pbxIcon.ErrorImage;
            }

            pbxIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Tag = res;
            this.AllowDrop = false;

            tt = new ToolTip();
            tt.SetToolTip(pbxIcon, "ID: " + res.ID + "\nNaziv: " + res.Name); 
        }

        private void ResourceIcon_MouseDown(object sender, MouseEventArgs e)
        {
            Size dragSize = SystemInformation.DragSize;
            mouseDownSelectionWindow = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
        }

        private void ResourceIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((mouseDownSelectionWindow != Rectangle.Empty)
                    && (!mouseDownSelectionWindow.Contains(e.X, e.Y)))
                {
                    displayOffset = SystemInformation.WorkingArea.Location;
                    DragDropEffects dropEffect = this.DoDragDrop(Tag, DragDropEffects.Copy);
                }
            }
        }

        private void pbxIcon_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            Resource res = (Resource)Tag;
            tt.SetToolTip(pbxIcon, "ID: " + MainForm.resources[res.ID].ID + "\nNaziv: " + MainForm.resources[res.ID].Name);
            tt.Active = true;
        }

        private void ResourceIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditResourceForm erf = new EditResourceForm(MainForm.resources[((Resource) Tag).ID]);
            erf.ShowDialog();

            if (erf.DialogResult == DialogResult.OK)
            {
                Resource res = erf.GetResource();
                tt.SetToolTip(pbxIcon, "ID: " + res.ID + "\nNaziv: " + res.Name);
                MainForm.resources[res.ID] = res;
                Tag = res;
            }
        }

        internal void SetToolTip(string p)
        {
            tt.SetToolTip(pbxIcon, p);
        }
    }
}
