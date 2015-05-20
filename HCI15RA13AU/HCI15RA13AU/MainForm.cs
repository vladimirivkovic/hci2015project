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

        public MainForm()
        {
            InitializeComponent();
            DeserializeTags();
            DeserializeTypes();
            DeserializeResources();
            DeserializeCoordinates();
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
            ResourcesTable resourcesTable = new ResourcesTable();
            resourcesTable.ShowDialog();

            updateMap();
        }

        private void typesResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypesTable typesTable = new TypesTable();
            typesTable.ShowDialog();
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagsTable tagsTable = new TagsTable();
            tagsTable.ShowDialog();
        }

        private void resursiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourcesTable resourcesTable = new ResourcesTable();
            resourcesTable.ShowDialog();
        }

        private void tipoviResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypesTable typesTable = new TypesTable();
            typesTable.ShowDialog();
        }

        private void etiketeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagsTable tagsTable = new TagsTable();
            tagsTable.ShowDialog();
        }

        private void pnlResources_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            off = 10;

            pnlResources.Controls.Clear();
            foreach (Resource res in resources.Values)
            {
                if (!resourceCoordinates.ContainsKey(res.ID))
                {
                    ResourceControl resControl = new ResourceControl(res, off);
                    pnlResources.Controls.Add(resControl);

                    off += 80;
                }
            }
            pnlResources.Refresh();

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
                    // delete from resourceCoordinates
                }
            }
        }

        private void pnlMap_DragEnter(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if ((e.Data.GetDataPresent(r.GetType())))
            {
                e.Effect = DragDropEffects.Copy;
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

                foreach (Control ctrl in pnlMap.Controls)
                {
                    if(ctrl.GetType().Equals(resIcon.GetType()))
                    {
                        if (((Resource)resIcon.Tag).ID == ((Resource)((ResourceIcon)ctrl).Tag).ID)
                        {
                            pnlMap.Controls.Remove(ctrl);
                        }
                    }
                }

                //resIcon.Left = (e.X - this.Left)/2;
                //resIcon.Top = (e.Y - this.Top)/2;

                pnlMap.Controls.Add(resIcon);

                resIcon.Left = (e.X - this.Left - pnlMap.Left - menuStrip1.Left - 30);
                resIcon.Top = (e.Y - this.Top - pnlMap.Top - menuStrip1.Top - 40);

                pnlMap.Refresh();

                if (!resourceCoordinates.ContainsKey(res.ID))
                {
                    resourceCoordinates.Add(res.ID, new ResourcePosition(res, resIcon.Left, resIcon.Top));
                    MainForm_Load(this, null);
                }
                else
                {
                    resourceCoordinates[res.ID].X = resIcon.Left;
                    resourceCoordinates[res.ID].Y = resIcon.Top;
                }

                
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
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
                        resCtrl.UpdateControl();
                    }
                }
            }

            int index, offset;
            Control subsitution;
            foreach (Control ctrl in deletedControls)
            {
                offset = ctrl.Top;
                index = pnlResources.Controls.IndexOf(ctrl);
                pnlResources.Controls.Remove(ctrl);
                //subsitution = pnlResources.Controls[pnlResources.Controls.Count - 1];
                //subsitution.Top = offset;
            }
            
        }

        private void pnlDelete_DragEnter(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if ((e.Data.GetDataPresent(r.GetType())))
            {
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
                    if (ctrl.Tag.Equals(res))
                    {
                        deleted = ctrl;
                        break;
                    }
                }

                if (deleted != null)
                {
                    pnlMap.Controls.Remove(deleted);
                    resourceCoordinates.Remove(res.ID);
                    pnlResources.Controls.Add(new ResourceControl(res, pnlResources.Controls.Count*80 + 10));
                }
            }
        }

        private void pnlResources_DragEnter(object sender, DragEventArgs e)
        {
            Resource r = new Resource();
            if ((e.Data.GetDataPresent(r.GetType())))
            {
                Resource res = (Resource)e.Data.GetData(r.GetType());
                if(!resourceCoordinates.ContainsKey(res.ID))
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
                    if (ctrl.Tag.Equals(res))
                    {
                        deleted = ctrl;
                        break;
                    }
                }

                if (deleted != null)
                {
                    pnlMap.Controls.Remove(deleted);
                    resourceCoordinates.Remove(res.ID);
                    pnlResources.Controls.Add(new ResourceControl(res, pnlResources.Controls.Count * 80 + 10));
                }
            }
        }

    }
}
