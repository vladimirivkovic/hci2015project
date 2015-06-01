using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace HCI15RA13AU
{
    public partial class MainForm : Form
    {

        public static Dictionary<string, Resource> resources = new Dictionary<string, Resource>();

        public static Dictionary<string, Type> types = new Dictionary<string, Type>();

        public static Dictionary<string, Tag> tags = new Dictionary<string, Tag>();

        public static Dictionary<string, ResourcePosition> resourceCoordinates = new Dictionary<string, ResourcePosition>();

        internal static string dateFormat = "dd.MM.yyyy";

        public static List<string> addedResources = new List<string>();

        private int off;

        public static bool tutorialMode = false;

        public static Color tutorialColor = Color.Red;

        public static int tutorialStep = 0;

        private Rectangle mouseDownSelectionWindow;
        private bool resourcesPanelRight = true;
        private Point displayOffset;

        public MainForm()
        {
            InitializeComponent();
            DeserializeTags();
            DeserializeTypes();
            DeserializeResources();
            DeserializeCoordinates();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            btnEndTutorial.Hide();
            pbxLeft.Hide();
            pbxDown.Hide();
            pbxRight.Hide();
        }

        private void DeserializeTags()
        {
            try
            {
                XmlSerializer tagsSerialzer = new XmlSerializer(typeof(TagItem[]), new XmlRootAttribute("ListOfTags"));
                FileStream buffer = File.Open("..\\..\\data\\tags.xml", FileMode.Open);

                TagItem[] items = tagsSerialzer.Deserialize(buffer) as TagItem[];
                foreach (TagItem item in items)
                {
                    tags.Add(item.ID, new Tag(item));
                }
                buffer.Close();
            }
            catch (IOException e1)
            {
                Console.WriteLine(e1.StackTrace);
            }
            catch (InvalidOperationException e2)
            {
                Console.WriteLine(e2.StackTrace);
            }
        }

        private void DeserializeTypes()
        {
            try
            {
                XmlSerializer typesSerialzer = new XmlSerializer(typeof(Type[]), new XmlRootAttribute("ListOfTypes"));
                FileStream buffer = File.Open("..\\..\\data\\types.xml", FileMode.Open);

                Type[] items = typesSerialzer.Deserialize(buffer) as Type[];
                foreach (Type item in items)
                {
                    types.Add(item.ID, new Type(item));
                }
                buffer.Close();
            }
            catch (IOException e1)
            {
                Console.WriteLine(e1.StackTrace);
            }
            catch (InvalidOperationException e2)
            {
                Console.WriteLine(e2.StackTrace);
            }
        }

        private void DeserializeResources()
        {
            try
            {
                XmlSerializer resSerialzer = new XmlSerializer(typeof(ResourceItem[]), new XmlRootAttribute("ListOfResources"));
                FileStream buffer = File.Open("..\\..\\data\\resources.xml", FileMode.Open);

                ResourceItem[] items = resSerialzer.Deserialize(buffer) as ResourceItem[];
                foreach (ResourceItem item in items)
                {
                    resources.Add(item.ID, new Resource(item));
                }
                buffer.Close();
            }
            catch (IOException e1)
            {
                Console.WriteLine(e1.StackTrace);
            }
            catch (InvalidOperationException e2)
            {
                Console.WriteLine(e2.StackTrace);
            }
        }

        private void DeserializeCoordinates()
        {
            try
            {
                XmlSerializer coordSerialzer = new XmlSerializer(typeof(ResourcePosition[]), new XmlRootAttribute("ListOfResourceCoordinates"));
                FileStream buffer = File.Open("..\\..\\data\\coordinates.xml", FileMode.Open);

                ResourcePosition[] items = coordSerialzer.Deserialize(buffer) as ResourcePosition[];
                foreach (ResourcePosition item in items)
                {
                    resourceCoordinates.Add(item.ID, new ResourcePosition(item));
                }
                buffer.Close();
            }
            catch (IOException e1)
            {
                Console.WriteLine(e1.StackTrace);
            }
            catch (InvalidOperationException e2)
            {
                Console.WriteLine(e2.StackTrace);
            }
        }

        public static void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer tagsSerialzer = new XmlSerializer(typeof(TagItem[]), new XmlRootAttribute("ListOfTags"));
            FileStream buffer = File.Open("..\\..\\data\\tags.xml", FileMode.Create);

            tagsSerialzer.Serialize(buffer, tags.Select(kv => new TagItem(kv.Value)).ToArray());
            buffer.Close();

            XmlSerializer typesSerialzer = new XmlSerializer(typeof(Type[]), new XmlRootAttribute("ListOfTypes"));
            FileStream buffer1 = File.Open("..\\..\\data\\types.xml", FileMode.Create);

            typesSerialzer.Serialize(buffer1, types.Select(kv => new Type(kv.Value)).ToArray());
            buffer1.Close();

            XmlSerializer resSerialzer = new XmlSerializer(typeof(ResourceItem[]), new XmlRootAttribute("ListOfResources"));
            FileStream buffer2 = File.Open("..\\..\\data\\resources.xml", FileMode.Create);

            resSerialzer.Serialize(buffer2, resources.Select(kv => new ResourceItem(kv.Value)).ToArray());
            buffer2.Close();

            XmlSerializer coordSerialzer = new XmlSerializer(typeof(ResourcePosition[]), new XmlRootAttribute("ListOfResourceCoordinates"));
            FileStream buffer3 = File.Open("..\\..\\data\\coordinates.xml", FileMode.Create);

            coordSerialzer.Serialize(buffer3, resourceCoordinates.Select(kv => new ResourcePosition(kv.Value)).ToArray());
            buffer3.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourcesTableForm resourcesTable = new ResourcesTableForm();
            resourcesTable.ShowDialog();

            updateMap();
        }

        private void typesResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypesTableForm typesTable = new TypesTableForm();
            typesTable.ShowDialog();

            updateMap();
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagsTableForm tagsTable = new TagsTableForm();
            tagsTable.ShowDialog();

            updateMap();
        }

        private void resursiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourcesTableForm resourcesTable = new ResourcesTableForm();
            resourcesTable.ShowDialog();
        }

        private void tipoviResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypesTableForm typesTable = new TypesTableForm();
            typesTable.ShowDialog();
        }

        private void etiketeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagsTableForm tagsTable = new TagsTableForm();
            tagsTable.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            off = 10;
            int cnt = 0;

            pnlResources.Controls.Clear();
            foreach (Resource res in resources.Values)
            {
                if (!resourceCoordinates.ContainsKey(res.ID))
                {
                    ResourceControl resControl = new ResourceControl(res, off);
                    pnlResources.Controls.Add(resControl);

                    off += 80;
                    cnt++;
                }
            }
            pnlResources.Refresh();
            lblUnmappedResources.Text = "Nemapirani resursi(" + cnt + ")";

            if (e == null)
                return;

            pnlMap.Controls.Clear();
            foreach (ResourcePosition rpos in resourceCoordinates.Values)
            {
                if (resources.ContainsKey(rpos.ID))
                {
                    ResourceIcon resIcon = new ResourceIcon(resources[rpos.ID]);
                    pnlMap.Controls.Add(resIcon);
                    resIcon.Left = rpos.X;
                    resIcon.Top = rpos.Y;
                }
                else
                {
                    resourceCoordinates.Remove(rpos.ID);
                }
            }
        }


        //pnlMap event handlers
        private void pnlMap_DragEnter(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if ((e.Data.GetDataPresent(r.GetType())))
            {
                if (tutorialMode && tutorialStep > 3)
                {
                    return;
                }
                Resource res = (Resource)e.Data.GetData(r.GetType());

                ResourceIcon resIcon = new ResourceIcon(res);

                Point p = pnlMap.PointToClient(new Point(e.X, e.Y));

                Rectangle rect = new Rectangle(
                    p.X - resIcon.Width / 2, p.Y - resIcon.Height/2,
                    resIcon.Width + 15, resIcon.Height + 15);
                lblCoordinates.Text = p.X + ", " + p.Y;

                bool boom = false;

                foreach (Control ctrl in pnlMap.Controls)
                {
                    if (ctrl.GetType().Equals(resIcon.GetType()))
                    {
                        if (((Resource)ctrl.Tag).ID == res.ID)
                        {
                            continue;
                        }
                        if (rect.IntersectsWith(ctrl.Bounds))
                        {
                            boom = true;
                            break;
                        }
                    }
                }

                lblMessage.Text = "";
                if (boom)
                {
                    lblMessage.Text = "Nemoguce je preklapanje ikonica";
                    e.Effect = DragDropEffects.None;
                }
                else
                {
                    e.Effect = DragDropEffects.Copy;
                }

                lblCoordinates.Text = p.X + ", " + p.Y;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnlMap_DragDrop(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if (e.Data.GetDataPresent(r.GetType()))
            {
                Resource res = (Resource)e.Data.GetData(r.GetType());

                ResourceIcon resIcon = new ResourceIcon(res);
                resIcon.Name = res.ID;

                Point p = pnlMap.PointToClient(new Point(e.X, e.Y));

                foreach (Control ctrl in pnlMap.Controls)
                {
                    if(ctrl.GetType().Equals(resIcon.GetType()))
                    {
                        if (((Resource)resIcon.Tag).ID == ((Resource)((ResourceIcon)ctrl).Tag).ID)
                        {
                            pnlMap.Controls.Remove(ctrl);
                            break;
                        }
                    }
                }

                pnlMap.Controls.Add(resIcon);

                resIcon.Left = p.X - 20;
                resIcon.Top = p.Y - 20;

                pnlMap.Refresh();

                if (tutorialMode)
                {
                    tutorialStep++;

                    if (tutorialStep == 1)
                    {
                        pbxLeft.SendToBack();
                        resIcon.BackColor = tutorialColor;
                        lblTutorial.Text = "Pomeri crvenu ikonicu na mapi";
                        pnlResources.Controls.RemoveAt(0);
                        foreach (Control ctrl in pnlResources.Controls)
                        {
                            if(!((Resource)ctrl.Tag).ID.Equals((((Resource)resIcon.Tag).ID)))
                            ctrl.Top -= 108;
                        }
                        pbxLeft.Hide();
                    }
                    else if (tutorialStep == 2)
                    {
                        resIcon.BackColor = Color.White;
                        lblTutorial.Text = "Prevuci crvenu stavku na mapu";
                        pnlResources.Controls[0].BackColor = tutorialColor;
                        pbxLeft.Show();
                    }
                    else if (tutorialStep == 3)
                    {
                        resIcon.BackColor = tutorialColor;
                        lblTutorial.Text = "Pomeri crvenu ikonicu na mapi";
                        pnlResources.Controls.RemoveAt(0);
                        foreach (Control ctrl in pnlResources.Controls)
                        {
                            if (!((Resource)ctrl.Tag).ID.Equals((((Resource)resIcon.Tag).ID)))
                                ctrl.Top -= 108;
                        }
                        pbxLeft.Hide();
                    }
                    else if (tutorialStep == 4)
                    {
                        foreach (Control ctrl in pnlMap.Controls)
                        {
                            if (ctrl.Tag != null && !((Resource)ctrl.Tag).ID.Equals(((Resource)resIcon.Tag).ID))
                            {
                                resIcon = (ResourceIcon) ctrl;
                                break;
                            }
                        }
                        resIcon.BackColor = tutorialColor;
                        lblTutorial.Text = "Prevuci crvenu ikonicu u kantu";
                        pbxDown.Show();
                    }
                    else if (tutorialStep == 5)
                    {
                        pnlMap.Controls[3].BackColor = tutorialColor;
                        lblTutorial.Text = "Prevuci crvenu ikonicu na listu nemapiranih resursa";
                        pbxRight.Show();
                    }


                    return;
                }

                if (!resourceCoordinates.ContainsKey(res.ID))
                {
                    resourceCoordinates.Add(res.ID, new ResourcePosition(res, resIcon.Left, resIcon.Top));
                    ////////////////
                    Control sub = null, deleted = null;
                    int maxTop = 0;

                    foreach (Control ctrl in pnlResources.Controls)
                    {
                        if (ctrl.Tag.Equals(res))
                        {
                            deleted = ctrl;
                            //break;
                        }
                        if (ctrl.Top > maxTop)
                        {
                            sub = ctrl;
                            maxTop = ctrl.Top;
                        }
                    }

                    if (deleted != null)
                    {
                        //ResourceControl resControl = deleted as ResourceControl;
                        sub.Top = deleted.Top;
                        pnlResources.Controls.Remove(deleted);
                        lblUnmappedResources.Text = "Nemapirani resursi(" + pnlResources.Controls.Count + ")";
                    }
                    /////////////
                    //MainForm_Load(this, null);
                }
                else
                {
                    resourceCoordinates[res.ID].X = resIcon.Left;
                    resourceCoordinates[res.ID].Y = resIcon.Top;
                }     
            }
        }

        private void pnlMap_MouseMove(object sender, MouseEventArgs e)
        {
            lblMessage.Text = "";
            lblCoordinates.Text = e.X + ", " + e.Y;
        }

        private void pnlMap_DragOver(object sender, DragEventArgs e)
        {
            pnlMap_DragEnter(sender, e);
            
        }

        private void updateMap()
        {
            List<Control> deletedControls = new List<Control>();
            ResourceIcon dummyIcon = new ResourceIcon();
            ResourceControl dummyResCtrl = new ResourceControl();

            foreach (Control ctrl in pnlMap.Controls)
            {
                if (ctrl.GetType().Equals(dummyIcon.GetType()))
                {
                    ResourceIcon resIcon = (ResourceIcon)ctrl;
                    if (!resources.ContainsKey(((Resource)resIcon.Tag).ID))
                    {
                        deletedControls.Add(ctrl);
                    }
                    else
                    {
                        Resource res = MainForm.resources[((Resource)resIcon.Tag).ID];
                        resIcon.Tag = res;
                        resIcon.UpdateControl();
                    }
                }
            }

            foreach (Control ctrl in deletedControls)
            {
                pnlMap.Controls.Remove(ctrl);
            }

            foreach (string id in addedResources)
            {
                Control ctrl = new ResourceControl(resources[id], pnlResources.Controls.Count * 80 + 10);
                pnlResources.Controls.Add(ctrl);
            }
            addedResources.Clear();
            lblUnmappedResources.Text = "Nemapirani resursi(" + pnlResources.Controls.Count + ")";

            deletedControls.Clear();

            foreach (Control ctrl in pnlResources.Controls)
            {
                if (ctrl.GetType().Equals(dummyResCtrl.GetType()))
                {
                    ResourceControl resCtrl = (ResourceControl)ctrl;
                    if (!resources.ContainsKey(((Resource)resCtrl.Tag).ID))
                    {
                        deletedControls.Add(ctrl);
                    }
                    else
                    {
                        Resource res = MainForm.resources[((Resource)resCtrl.Tag).ID];
                        resCtrl.Tag = res;
                        
                    }
                    resCtrl.UpdateControl();
                }
            }

            if (deletedControls.Count > 0)
            {
                MainForm_Load(this, null);
            }
        }


        //pnlDelete event handlers
        private void pnlDelete_DragEnter(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if ((e.Data.GetDataPresent(r.GetType())))
            {
                if (tutorialMode && tutorialStep != 4)
                {
                    return;
                }
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnlDelete_DragDrop(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if (e.Data.GetDataPresent(r.GetType()))
            {
                Resource res = (Resource)e.Data.GetData(r.GetType());

                Control deleted = null;

                foreach (Control ctrl in pnlMap.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.Equals(res))
                    {
                        deleted = ctrl;
                        break;
                    }
                }

                

                if (deleted != null)
                {
                    removeResource(deleted as ResourceIcon);
                    if (tutorialMode)
                    {
                        tutorialStep++;
                        pnlMap.Controls[3].BackColor = tutorialColor;
                        lblTutorial.Text = "Prevuci crvenu ikonicu na listu nemapiranih resursa";
                        pbxDown.Hide();
                        pbxRight.Show();
                    }
                }
                else
                {
                    
                    Control sub = null;
                    int maxTop = 0;

                    foreach (Control ctrl in pnlResources.Controls)
                    {
                        if (ctrl.Tag.Equals(res))
                        {
                            deleted = ctrl;
                            //break;
                        }
                        if(ctrl.Top > maxTop)
                        {
                            sub = ctrl;
                            maxTop = ctrl.Top;
                        }
                    }

                    if (deleted != null)
                    {
                        ///////////////////////
                        sub.Top = deleted.Top;
                        pnlResources.Controls.Remove(deleted);
                        lblUnmappedResources.Text = "Nemapirani resursi(" + pnlResources.Controls.Count + ")";
                        ////////////////////////
                        //resources.Remove(res.ID);
                        //MainForm_Load(this, null);
                    }
                    
                }
            }
        }


        //pnlResource events handlers
        private void pnlResources_DragEnter(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if ((e.Data.GetDataPresent(r.GetType())))
            {
                Resource res = (Resource)e.Data.GetData(r.GetType());
                if (tutorialMode && tutorialStep == 5)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else if(!resourceCoordinates.ContainsKey(res.ID))
                {
                    e.Effect = DragDropEffects.None;
                }
                else
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnlResources_DragDrop(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if (e.Data.GetDataPresent(r.GetType()))
            {
                Resource res = (Resource)e.Data.GetData(r.GetType());

                Control deleted = null;

                foreach (Control ctrl in pnlMap.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.Equals(res))
                    {
                        deleted = ctrl;
                        break;
                    }
                }

                if (tutorialMode)
                {
                    lblTutorial.Text = "Tutorijal je uspesno zavrsen!";
                    pbxRight.Hide();
                }

                if (deleted != null)
                {
                    pnlMap.Controls.Remove(deleted);
                    resourceCoordinates.Remove(res.ID);
                    if (tutorialMode)
                    {
                        pnlResources.Controls.Add(new ResourceControl(res, pnlResources.Controls.Count * 80 + 10));
                    }
                    else
                    {
                        pnlResources.Controls.Add(new ResourceControl(resources[res.ID], pnlResources.Controls.Count * 80 + 10));
                    }
                }
                lblUnmappedResources.Text = "Nemapirani resursi(" + pnlResources.Controls.Count + ")";
            }
        }

        internal void moveToPnlResources(ResourceIcon resourceIcon)
        {
            Resource res = resourceIcon.Tag as Resource;

            pnlMap.Controls.Remove(resourceIcon);
            resourceCoordinates.Remove(res.ID);

            Control ctrl = new ResourceControl(resources[res.ID], pnlResources.Controls.Count * 80 + 10);
            pnlResources.Controls.Add(ctrl);
            lblUnmappedResources.Text = "Nemapirani resursi(" + pnlResources.Controls.Count + ")";
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }


        internal void removeResource(ResourceIcon resourceIcon)
        {
            Resource res = resourceIcon.Tag as Resource;

            pnlMap.Controls.Remove(resourceIcon);
            resourceCoordinates.Remove(res.ID);
            resources.Remove(res.ID);
        }

        internal int GetPnlResourcesVerticalScroll()
        {
            if(pnlResources.VerticalScroll.Value > 0)
                return (int) (pnlResources.VerticalScroll.Value/1.35);
            return 0;
        }

        
        // tutorial
        private void tutorijalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tutorialMode = true;

            Tutorial t = new Tutorial(this);
            btnEndTutorial.Show();


            menuStrip1.Enabled = false;

            pnlMap.Controls.Clear();
            pnlResources.Controls.Clear();
            Resource[] dummyResources = t.GenerateDummyResources();

            ResourceControl firstControl = new ResourceControl(dummyResources[0], 10);
            firstControl.SetBackgroundColor(tutorialColor);
            pnlResources.Controls.Add(firstControl);
            for (int i = 1; i < dummyResources.Length; i++)
            {
                pnlResources.Controls.Add(new ResourceControl(dummyResources[i], pnlResources.Controls.Count * 80 + 10));
            }

            lblTutorial.Text = "Prevuci crvenu stavku na mapu";

            pnlMap.Controls.Add(pbxLeft);
            pnlMap.Controls.Add(pbxDown);
            pnlMap.Controls.Add(pbxRight);
            pbxLeft.Show();
        }

        private void btnEndTutorial_Click(object sender, EventArgs e)
        {
            tutorialMode = false;
            tutorialStep = 0;
            MainForm_Load(this, EventArgs.Empty);
            btnEndTutorial.Hide();
            menuStrip1.Enabled = true;
            lblTutorial.Text = "";
        }


        // help provider
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\help\\help project.chm");
        }

        private void pnlResources_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((mouseDownSelectionWindow != Rectangle.Empty)
                    && (!mouseDownSelectionWindow.Contains(e.X, e.Y)))
                {
                    if (MainForm.tutorialMode)
                    {
                        return;
                    }
                    displayOffset = SystemInformation.WorkingArea.Location;
                    DragDropEffects dropEffect = this.DoDragDrop(pnlResources, DragDropEffects.Copy);
                }
            }
        }

        private void pnlResources_MouseDown(object sender, MouseEventArgs e)
        {
            Size dragSize = SystemInformation.DragSize;
            mouseDownSelectionWindow = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.Data.GetDataPresent(pnlResources.GetType())))
            {
                if (tutorialMode)
                {
                    e.Effect = DragDropEffects.None;
                }

                Point p = new Point(e.X, e.Y);
                p = this.PointToClient(p);

                if (p.X <= pnlResources.Width && resourcesPanelRight)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else if (p.X >= pnlMap.Width && !resourcesPanelRight)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if ((e.Data.GetDataPresent(pnlResources.GetType())))
            {
                Image img;
                if (resourcesPanelRight)
                {
                    pnlResources.Left = 12;
                    lblUnmappedResources.Left = 12;
                    pnlMap.Left += pnlResources.Width + 9;
                    pnlDelete.Left += pnlMap.Width + 9 + pnlResources.Width - pnlDelete.Width;
                    resourcesPanelRight = false;
                    pbxDown.Left += pnlMap.Width - pnlDelete.Width;
                    pbxLeft.Left = 0;
                    pbxRight.Left = 0;
                    img = pbxLeft.BackgroundImage;
                    pbxLeft.BackgroundImage = pbxRight.BackgroundImage;
                    pbxRight.BackgroundImage = img;
                    lblTutorial.Left += pnlResources.Width - pnlDelete.Width;
                }
                else
                {
                    pnlResources.Left = pnlMap.Width + 19;
                    lblUnmappedResources.Left = pnlMap.Width + 19;
                    pnlMap.Left -= pnlResources.Width + 9;
                    pnlDelete.Left -= pnlMap.Width + 9 + pnlResources.Width - pnlDelete.Width;
                    resourcesPanelRight = true;
                    pbxDown.Left -= pnlMap.Width - pnlDelete.Width;
                    pbxLeft.Left = pnlMap.Width - pbxLeft.Width;
                    pbxRight.Left = pnlMap.Width - pbxRight.Width;
                    img = pbxLeft.BackgroundImage;
                    pbxLeft.BackgroundImage = pbxRight.BackgroundImage;
                    pbxRight.BackgroundImage = img;
                    lblTutorial.Left -= pnlResources.Width - pnlDelete.Width;
                }
            }
        }

        public static Tag GetTagBySecondID(string secondID)
        {
            Tag t = null;

            foreach (Tag tg in tags.Values)
            {
                if (tg.SecondID.Equals(secondID))
                {
                    t = tg;
                    break;
                }
            }

            return t;
        }

        public static Type GetTypeBySecondID(string secondID)
        {
            Type t = null;

            foreach (Type tg in types.Values)
            {
                if (tg.SecondID.Equals(secondID))
                {
                    t = tg;
                    break;
                }
            }

            return t;
        }

        public static Resource GetResourceBySecondID(string secondID)
        {
            Resource r = null;

            foreach (Resource res in resources.Values)
            {
                if (res.SecondID.Equals(secondID))
                {
                    r = res;
                    break;
                }
            }

            return r;
        }
    }
}
