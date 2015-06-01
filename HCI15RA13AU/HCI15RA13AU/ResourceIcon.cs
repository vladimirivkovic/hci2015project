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

            tt = new ToolTip();
            this.Tag = res;

            if(MainForm.tutorialMode == false)
                pbxIcon.ContextMenuStrip = contextMenu;

            UpdateControl();
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
                    if (MainForm.tutorialMode && !BackColor.Equals(MainForm.tutorialColor))
                    {
                        return;
                    }
                    displayOffset = SystemInformation.WorkingArea.Location;
                    DragDropEffects dropEffect = this.DoDragDrop(Tag, DragDropEffects.Copy);
                }
            }
        }

        private void pbxIcon_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            Resource res = (Resource)Tag;
            tt.SetToolTip(pbxIcon, "ID: " + res.SecondID + "\nNaziv: " + res.Name);
            tt.Active = true;
        }

        private void ResourceIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MainForm.tutorialMode)
            {
                return;
            }

            NewResourceForm erf = new NewResourceForm(MainForm.resources[((Resource)Tag).ID]);
            erf.ShowDialog();

            if (erf.DialogResult == DialogResult.OK)
            {
                Resource res = erf.GetResource();
                MainForm.resources[res.ID] = res;
                UpdateControl();
            }
        }

        public void UpdateControl()
        {
            Resource res = MainForm.resources[((Resource)Tag).ID];
            Tag = res;

            try
            {
                pbxIcon.Image = Image.FromFile(res.IconFileName);
            }
            catch (Exception)
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

            Panel pnlColor = new Panel();

            for (int j = 0; j < this.Controls.Count; j++)
            {
                if (this.Controls[j].GetType().Equals(pnlColor.GetType()))
                {
                    this.Controls.RemoveAt(j);
                    j--;
                }
            }

            //Panel pnlColor;
            int i = 0;
            int count = res.Tags.Count;
            int w = 0;
            if (count > 0)
            {
                w = this.Width / count;
            }
            foreach (Tag tag in res.Tags.Values)
            {
                pnlColor = new Panel();
                pnlColor.Width = w;
                pnlColor.Height = this.Height / 4;
                pnlColor.BackColor = tag.Color;

                pnlColor.Left = i++ * w;
                pnlColor.Top = pbxIcon.Top + pbxIcon.Height;

                this.Controls.Add(pnlColor);
            }

            this.Refresh();
        }

        private void ukloniSaMapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((MainForm)MainForm.ActiveForm).moveToPnlResources(this);
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewResourceForm erf = new NewResourceForm(MainForm.resources[((Resource)Tag).ID]);
            erf.ShowDialog();

            if (erf.DialogResult == DialogResult.OK)
            {
                Resource res = erf.GetResource();
                MainForm.resources[res.ID] = res;
                UpdateControl();
            }
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((MainForm)MainForm.ActiveForm).removeResource(this);
        }
    }
}
