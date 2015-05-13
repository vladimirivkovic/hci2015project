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
        }
    }
}
