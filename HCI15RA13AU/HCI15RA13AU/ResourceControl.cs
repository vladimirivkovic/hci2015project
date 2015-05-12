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
    public partial class ResourceControl : UserControl
    {
        private Rectangle mouseDownSelectionWindow;
        private bool dragged;
        private Point displayOffset;

        public ResourceControl()
        {
            InitializeComponent();
        }

        public ResourceControl(Resource res, int offset)
        {
            InitializeComponent();
            lblID.Text = res.ID;
            lblName.Text = res.Name;
            try
            {
                pbxIcon.Image = Image.FromFile(res.IconFileName);
            }
            catch (FileNotFoundException fnfe)
            {
                pbxIcon.Image = pbxIcon.InitialImage;
                Console.WriteLine(fnfe.StackTrace);
            }
            pbxIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Top = offset;

            this.Tag = res;

            dragged = false;
        }

        public void ResourceControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (!dragged)
            {
                Size dragSize = SystemInformation.DragSize;
                mouseDownSelectionWindow = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                mouseDownSelectionWindow = Rectangle.Empty;
            }
        }

        public void ResourceControl_MouseMove(object sender, MouseEventArgs e)
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
    }
}
