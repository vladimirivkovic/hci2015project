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

        public static Dictionary<string, Resource> mappedResources = new Dictionary<string, Resource>();

        internal static string dateFormat = "dd.MM.yyyy";

        public MainForm()
        {
            InitializeComponent();
            DeserializeTags();
            DeserializeTypes();
            DeserializeResources();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlSerializer tagsSerialzer = new XmlSerializer(typeof(TagItem[]), new XmlRootAttribute("ListOfTags"));
            FileStream buffer = File.Open("tags.xml", FileMode.Create);

            tagsSerialzer.Serialize(buffer, tags.Select(kv => new TagItem(kv.Value)).ToArray());
            buffer.Close();

            XmlSerializer typesSerialzer = new XmlSerializer(typeof(Type[]), new XmlRootAttribute("ListOfTypes"));
            FileStream buffer1 = File.Open("types.xml", FileMode.Create);

            typesSerialzer.Serialize(buffer1, types.Select(kv => new Type(kv.Value)).ToArray());
            buffer1.Close();

            XmlSerializer resSerialzer = new XmlSerializer(typeof(ResourceItem[]), new XmlRootAttribute("ListOfResources"));
            FileStream buffer2 = File.Open("resources.xml", FileMode.Create);

            resSerialzer.Serialize(buffer2, resources.Select(kv => new ResourceItem(kv.Value)).ToArray());
            buffer2.Close();
        }

        private void DeserializeTags()
        {
            try
            {
                XmlSerializer tagsSerialzer = new XmlSerializer(typeof(TagItem[]), new XmlRootAttribute("ListOfTags"));
                FileStream buffer = File.Open("tags.xml", FileMode.Open);

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
                FileStream buffer = File.Open("types.xml", FileMode.Open);

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
                FileStream buffer = File.Open("resources.xml", FileMode.Open);

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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer tagsSerialzer = new XmlSerializer(typeof(TagItem[]), new XmlRootAttribute("ListOfTags"));
            FileStream buffer = File.Open("tags.xml", FileMode.Create);

            tagsSerialzer.Serialize(buffer, tags.Select(kv => new TagItem(kv.Value)).ToArray());
            buffer.Close();

            XmlSerializer typesSerialzer = new XmlSerializer(typeof(Type[]), new XmlRootAttribute("ListOfTypes"));
            FileStream buffer1 = File.Open("types.xml", FileMode.Create);

            typesSerialzer.Serialize(buffer1, types.Select(kv => new Type(kv.Value)).ToArray());
            buffer1.Close();

            XmlSerializer resSerialzer = new XmlSerializer(typeof(ResourceItem[]), new XmlRootAttribute("ListOfResources"));
            FileStream buffer2 = File.Open("resources.xml", FileMode.Create);

            resSerialzer.Serialize(buffer2, resources.Select(kv => new ResourceItem(kv.Value)).ToArray());
            buffer2.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourcesTable resourcesTable = new ResourcesTable();
            resourcesTable.ShowDialog();
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
            int off = 10;

            pnlResources.Controls.Clear();
            foreach (Resource res in resources.Values)
            {
                if (!mappedResources.ContainsKey(res.ID))
                {
                    ResourceControl resControl = new ResourceControl(res, off);
                    pnlResources.Controls.Add(resControl);

                    off += 60;
                }
            }
            pnlResources.Refresh();
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
            Panel dropPicturePanel = (Panel)sender;
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

                if (pnlMap.Controls.ContainsKey(res.ID))
                {
                    lblX.Text = "Mujo";
                }

                lblX.Text = e.X.ToString();
                lblY.Text = e.Y.ToString();

                //resIcon.Left = (e.X - this.Left)/2;
                //resIcon.Top = (e.Y - this.Top)/2;

                pnlMap.Controls.Add(resIcon);

                resIcon.Left = (e.X - this.Left - pnlMap.Left - menuStrip1.Left - 16);
                resIcon.Top = (e.Y - this.Top - pnlMap.Top - menuStrip1.Top - 16);

                pnlMap.Refresh();

                if (!mappedResources.ContainsKey(res.ID))
                {
                    mappedResources.Add(res.ID, res);
                    MainForm_Load(this, EventArgs.Empty);
                }
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }


    }
}
