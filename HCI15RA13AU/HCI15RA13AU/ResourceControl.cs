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
            lblID.Text = res.SecondID;
            lblName.Text = res.Name;
            lblType.Text = res.Type.SecondID;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(lblID, "oznaka resursa");
            tt.SetToolTip(lblName, "naziv resursa");
            tt.SetToolTip(lblType, "oznaka tipa");


            try
            {
                pbxIcon.Image = Image.FromFile(res.IconFileName);
            }
            catch (Exception fnfe)
            {
                try
                {
                    pbxIcon.Image = Image.FromFile(res.Type.IconFileName);
                }
                catch (Exception fnfe1)
                {
                    pbxIcon.Image = pbxIcon.InitialImage;
                    Console.WriteLine(fnfe1.StackTrace);
                }
            }
            pbxIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            int vscroll = 0;
            if (MainForm.ActiveForm as MainForm != null)
            {
                vscroll = ((MainForm)MainForm.ActiveForm).GetPnlResourcesVerticalScroll();
            }

            this.Top = offset - vscroll;
            this.Left = 20;

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
                    if (MainForm.tutorialMode && !BackColor.Equals(MainForm.tutorialColor))
                    {
                        return;
                    }
                    displayOffset = SystemInformation.WorkingArea.Location;
                    DragDropEffects dropEffect = this.DoDragDrop(Tag, DragDropEffects.Copy);
                }
            }
        }

        internal void UpdateControl()
        {
            Resource res = (Resource)this.Tag;
            lblID.Text = res.SecondID;
            lblName.Text = res.Name;
            lblType.Text = MainForm.types[res.Type.ID].SecondID;

            try
            {
                pbxIcon.Image = Image.FromFile(res.IconFileName);
            }
            catch (FileNotFoundException fnfe)
            {
                try
                {
                    pbxIcon.Image = Image.FromFile(res.Type.IconFileName);
                }
                catch (FileNotFoundException fnfe1)
                {
                    pbxIcon.Image = pbxIcon.InitialImage;
                    Console.WriteLine(fnfe1.StackTrace);
                }
            }
            pbxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void SetBackgroundColor(Color c)
        {
            this.BackColor = c;
        }
    }
}
