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

        //private void btnAddResource_Click(object sender, EventArgs e)
        //{
        //    NewResourceForm addForm = new NewResourceForm();
        //    addForm.ShowDialog();

        //    if (addForm.DialogResult == DialogResult.OK)
        //    {
        //        Resource res = addForm.GetResource();
        //        resources.Add(res.ID, res);
        //        dgwResources.Rows.Add(new object[] { res.ID, res.Name, res.Discovered.ToString(dateFormat),
        //            res.Cost.ToString("C"), res.Important, res.Renewable,
        //            Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit) });
        //        dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
        //        dgwResources.CurrentCell = dgwResources.Rows[dgwResources.Rows.Count - 1].Cells[0];
        //        dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
        //    }
        //}

        //private void btnEditResource_Click(object sender, EventArgs e)
        //{
        //    if (dgwResources.SelectedRows.Count > 0)
        //    {
        //        EditResourceForm erf = new EditResourceForm((Resource)dgwResources.SelectedRows[0].Tag);
        //        erf.ShowDialog();

        //        if (erf.DialogResult == DialogResult.OK)
        //        {
        //            foreach (DataGridViewRow row in dgwResources.SelectedRows)
        //            {
        //                if (row.Selected)
        //                {
        //                    Resource res = erf.GetResource();
        //                    int index = dgwResources.Rows.IndexOf(row);
        //                    dgwResources.Rows.RemoveAt(index);
        //                    dgwResources.Rows.Insert(index, new object[] { res.ID, res.Name, res.Discovered.ToString(dateFormat),
        //                        res.Cost.ToString("C"), res.Important, res.Renewable,
        //                        Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit) });
        //                    dgwResources.Rows[index].Tag = res;
        //                    dgwResources.CurrentCell = dgwResources.Rows[index].Cells[0];
        //                    resources.Remove(res.ID);
        //                    resources.Add(res.ID, res);
        //                    break;
        //                }
        //            }
        //            dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
        //        }
        //    }
        //}

        //private void dgwResources_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgwResources.SelectedRows.Count == 0)
        //    {
        //        txtId.Text = "";
        //        txtFrequency.Text = "";
        //        txtName.Text = "";
        //        txtUnit.Text = "";
        //        chbExploatable.Checked = false;
        //        chbImportant.Checked = false;
        //        chbRenewable.Checked = false;
        //        txtDescription.Text = "";
        //        txtTypeId.Text = "";
        //        txtTypeName.Text = "";
        //        lvTags.Clear();
        //        pbxIcon.Hide();
        //    }
        //    else
        //    {
        //        Resource res = (Resource)dgwResources.SelectedRows[0].Tag;
        //        if (res != null)
        //        {
        //            txtId.Text = res.ID;
        //            txtFrequency.Text = Resource.FrequencyToString(res.Frequency);
        //            txtName.Text = res.Name;
        //            txtUnit.Text = Resource.UnitToString(res.Unit);
        //            chbExploatable.Checked = res.Exploatable;
        //            chbImportant.Checked = res.Important;
        //            chbRenewable.Checked = res.Renewable;
        //            txtDescription.Text = res.Description;
        //            txtTypeId.Text = res.Type.ID;
        //            txtTypeName.Text = res.Type.Name;
        //            lvTags.Clear();
        //            if (res.Tags.Count > 0)
        //            {
        //                int i = 0;
        //                foreach (Tag t in res.Tags.Values)
        //                {
        //                    ListViewItem lvi = new ListViewItem(t.ID);
        //                    lvi.BackColor = t.Color;
        //                    lvTags.Items.Add(lvi);
        //                    if (++i > 4)
        //                    {
        //                        break;
        //                    }
        //                }
        //            }
        //            pbxIcon.Show();
        //            if (!res.IconFileName.Equals(""))
        //            {
        //                try
        //                {
        //                    pbxIcon.Image = Image.FromFile(res.IconFileName);
        //                    pbxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
        //                }
        //                catch (FileNotFoundException fnfe)
        //                {
        //                    //pbxIcon.Image = pbxIcon.ErrorImage;
        //                    try
        //                    {
        //                        pbxIcon.Image = Image.FromFile(res.Type.IconFileName);
        //                        Console.WriteLine(fnfe.StackTrace);
        //                    }
        //                    catch (FileNotFoundException fnfe1)
        //                    {
        //                        pbxIcon.Image = pbxIcon.ErrorImage;
        //                        //pbxIcon.Image = Image.FromFile(res.Type.IconFileName);
        //                        Console.WriteLine(fnfe1.StackTrace);
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                pbxIcon.Image = Image.FromFile(res.Type.IconFileName);
        //                //pbxIcon.Image = pbxIcon.InitialImage;
        //            }
        //        }
        //    }
        //}

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    dgwResources.Rows.Clear();
        //    foreach (Resource res in resources.Values)
        //    {
        //        dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
        //            res.Discovered.ToString(dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable,
        //            Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
        //        dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
        //    }
        //    if (dgwResources.Rows.Count > 0)
        //    {
        //        dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
        //        dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
        //    }

        //    dgwTags.Rows.Clear();
        //    foreach (Tag t in tags.Values)
        //    {
        //        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
        //        cellStyle.BackColor = t.Color;
        //        dgwTags.Rows.Add(new object[] { t.ID, "" });
        //        dgwTags.Rows[dgwTags.Rows.Count - 1].Tag = t;
        //        dgwTags.Rows[dgwTags.Rows.Count - 1].Cells[1].Style = cellStyle;
        //    }
        //    if (dgwTags.Rows.Count > 0)
        //    {
        //        dgwTags.CurrentCell = dgwTags.Rows[0].Cells[0];
        //    }

        //    dgwTypes.Rows.Clear();
        //    foreach (Type t in types.Values)
        //    {
        //        dgwTypes.Rows.Add(new object[] { t.ID, t.Name} );
        //        dgwTypes.Rows[dgwTypes.Rows.Count - 1].Tag = t;
        //    }
        //    if (dgwTypes.Rows.Count > 0)
        //    {
        //        dgwTypes.CurrentCell = dgwTypes.Rows[0].Cells[0];
        //    }
        //}

        //private void btnNewType_Click(object sender, EventArgs e)
        //{
        //    TypeForm tf;
        //    tf = new TypeForm();
        //    tf.ShowDialog();

        //    if (tf.DialogResult == DialogResult.OK)
        //    {
        //        Type t = tf.GetResourceType();
        //        types.Add(t.ID, t);
        //        dgwTypes.Rows.Add(new object[] { t.ID, t.Name} );
        //        dgwTypes.Rows[dgwTypes.Rows.Count - 1].Tag = t;
        //        dgwTypes.CurrentCell = dgwTypes.Rows[dgwTypes.Rows.Count - 1].Cells[0];
        //    }
        //}

        //private void btnEditType_Click(object sender, EventArgs e)
        //{
        //    if (dgwTypes.SelectedRows.Count > 0)
        //    {
        //        TypeForm tf = new TypeForm((Type)dgwTypes.SelectedRows[0].Tag);
        //        tf.ShowDialog();

        //        if (tf.DialogResult == DialogResult.OK)
        //        {
        //            foreach (DataGridViewRow row in dgwTypes.SelectedRows)
        //            {
        //                if (row.Selected)
        //                {
        //                    Type t = tf.GetResourceType();
        //                    int index = dgwTypes.Rows.IndexOf(row);
        //                    dgwTypes.Rows.RemoveAt(index);
        //                    dgwTypes.Rows.Insert(index, new object[] { t.ID, t.Name});
        //                    dgwTypes.Rows[index].Tag = t;
        //                    dgwTypes.CurrentCell = dgwTypes.Rows[index].Cells[0];
        //                    types.Remove(t.ID);
        //                    types.Add(t.ID, t);
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void btnNewTag_Click(object sender, EventArgs e)
        //{
        //    TagForm nt = new TagForm();
        //    nt.ShowDialog();

        //    if (nt.DialogResult == DialogResult.OK)
        //    {
        //        Tag t = nt.GetTag();
        //        tags.Add(t.ID, t);

        //        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
        //        cellStyle.BackColor = t.Color;
        //        dgwTags.Rows.Add(new object[] { t.ID, "" });
        //        dgwTags.Rows[dgwTags.Rows.Count - 1].Tag = t;
        //        dgwTags.Rows[dgwTags.Rows.Count - 1].Cells[1].Style = cellStyle;
        //        dgwTags.CurrentCell = dgwTags.Rows[dgwTags.Rows.Count - 1].Cells[0];
        //    }
        //}

        //private void btnEditTag_Click(object sender, EventArgs e)
        //{
        //    if (dgwTags.SelectedRows.Count > 0)
        //    {
        //        TagForm tf = new TagForm((Tag)dgwTags.SelectedRows[0].Tag);
        //        tf.ShowDialog();

        //        if (tf.DialogResult == DialogResult.OK)
        //        {
        //            foreach (DataGridViewRow row in dgwTags.SelectedRows)
        //            {
        //                if (row.Selected)
        //                {
        //                    Tag t = tf.GetTag();

        //                    DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
        //                    cellStyle.BackColor = t.Color;

        //                    int index = dgwTags.Rows.IndexOf(row);
        //                    dgwTags.Rows.RemoveAt(index);
        //                    dgwTags.Rows.Insert(index, new object[] { t.ID, "" });
        //                    dgwTags.Rows[index].Tag = t;
        //                    dgwTags.Rows[index].Cells[1].Style = cellStyle;
        //                    dgwTags.CurrentCell = dgwTags.Rows[index].Cells[0];
        //                    tags.Remove(t.ID);
        //                    tags.Add(t.ID, t);
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void btnDeleteResource_Click(object sender, EventArgs e)
        //{
        //    if (dgwResources.SelectedRows.Count == 0)
        //        return;
        //    DataGridViewRow row = dgwResources.SelectedRows[0];
        //    if(row != null) 
        //    {
        //        int index = dgwResources.Rows.IndexOf(row);
        //        Resource res = (Resource) row.Tag;
        //        if (res != null)
        //        {
        //            resources.Remove(res.ID);
        //        }
        //        dgwResources.Rows.RemoveAt(index);
        //    }
        //}

        //private void btnDeleteType_Click(object sender, EventArgs e)
        //{
        //    if (dgwTypes.SelectedRows.Count == 0)
        //        return;
        //    DataGridViewRow row = dgwTypes.SelectedRows[0];
        //    if (row != null)
        //    {
        //        int index = dgwTypes.Rows.IndexOf(row);
        //        Type t = (Type)row.Tag;
        //        if (t != null)
        //        {
        //            List<Resource> deleted = new List<Resource>();
        //            List<DataGridViewRow> rows = new List<DataGridViewRow>();
        //            foreach (Resource res in resources.Values)
        //            {
        //                if (res.Type.ID == t.ID)
        //                {
        //                    deleted.Add(res);
        //                    foreach (DataGridViewRow r in dgwResources.Rows)
        //                    {
        //                        if (((Resource)r.Tag).ID == res.ID)
        //                        {
        //                            rows.Add(r);
        //                        }
        //                    }
        //                }
        //            }
        //            if (deleted.Count > 0)
        //            {
        //                StringBuilder sb = new StringBuilder("Brisanjem tipa biće obrisani i sledeci resursi toga tipa:\n");
        //                foreach (Resource res in deleted)
        //                {
        //                    sb.AppendLine(res.ID);
        //                }
        //                sb.AppendLine("Da li želite da nastavite sa brisanjem?");
        //                DialogResult result = MessageBox.Show(sb.ToString(),
        //                    "Brisanje tipa resursa", MessageBoxButtons.OKCancel);
        //                if (result == DialogResult.Cancel)
        //                {
        //                    return;
        //                }
        //            }
        //            foreach (Resource id in deleted)
        //            {
        //                resources.Remove(id.ID);
        //            }
        //            foreach (DataGridViewRow i in rows)
        //            {
        //                dgwResources.Rows.Remove(i);
        //            }
        //            types.Remove(t.ID);
        //        }
        //        dgwTypes.Rows.RemoveAt(index);
        //    }
        //}

        //private void btnDeleteTag_Click(object sender, EventArgs e)
        //{
        //    if (dgwTags.SelectedRows.Count == 0)
        //        return;
        //    DataGridViewRow row = dgwTags.SelectedRows[0];
        //    if (row != null)
        //    {
        //        int index = dgwTags.Rows.IndexOf(row);
        //        Tag t = (Tag)row.Tag;
        //        if (t != null)
        //        {
        //            List<Resource> deleted = new List<Resource>(); 
        //            foreach (Resource res in resources.Values)
        //            {
        //                //bool contains = false;
        //                foreach (Tag tg in res.Tags.Values)
        //                {
        //                    if (tg.ID == t.ID)
        //                    {
        //                        deleted.Add(res);
        //                    }
        //                }
        //            }
        //            foreach (Resource res in deleted)
        //            {
        //                if (res.Tags.ContainsKey(t.ID))
        //                {
        //                    MainForm.resources[res.ID].Tags.Remove(t.ID);
        //                }
        //            }
        //            tags.Remove(t.ID);
        //            dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
        //        }
        //        dgwTags.Rows.RemoveAt(index);
        //    }
        //}

        

        //private void dgwTypes_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgwTypes.SelectedRows.Count == 0)
        //    {
        //        txtTypeDesc.Text = "";
        //        pbxTypeIcon.Image = null;
        //    }
        //    else
        //    {
        //        Type t = (Type) dgwTypes.SelectedRows[0].Tag;
        //        if (t != null)
        //        {
        //            txtTypeDesc.Text = t.Description;
        //            if (!t.IconFileName.Equals(""))
        //            {
        //                try
        //                {
        //                    pbxTypeIcon.Image = Image.FromFile(t.IconFileName);
        //                    pbxTypeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
        //                }
        //                catch (FileNotFoundException e1)
        //                {
        //                    pbxTypeIcon.Image = pbxTypeIcon.ErrorImage;
        //                    Console.WriteLine(e1.StackTrace);
        //                }
        //            }
        //            else
        //            {
        //                pbxTypeIcon.Image = pbxTypeIcon.InitialImage; ;
        //            }
        //        }
        //    }
        //}

        //private void dgwTags_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgwTags.SelectedRows.Count == 0)
        //    {
        //        txtTagDesc.Text = "";
        //        txtColor.ForeColor = Color.White;
        //    }
        //    else
        //    {
        //        Tag t = (Tag)dgwTags.SelectedRows[0].Tag;
        //        if (t != null)
        //        {
        //            txtTagDesc.Text = t.Description;
        //            txtColor.BackColor = t.Color;
        //        }
        //    }
        //}

        

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    if(txtSearch.Text.Equals(""))
        //    {
        //        dgwResources.Rows.Clear();
        //        foreach (Resource res in resources.Values)
        //        {
        //            dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
        //            res.Discovered.ToString(dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable,
        //            Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
        //            dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
        //        }
        //        if (dgwResources.Rows.Count > 0)
        //        {
        //            dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
        //            dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
        //        }
        //    }
        //    else
        //    {
        //        dgwResources.Rows.Clear();
        //        foreach (Resource res in resources.Values)
        //        {
        //            if (res.ID.StartsWith(txtSearch.Text))
        //            {
        //                dgwResources.Rows.Add(new object[] { res.ID, res.Name, 
        //                res.Discovered.ToString(dateFormat), res.Cost.ToString("C"), res.Important, res.Renewable,
        //                Resource.FrequencyToString(res.Frequency), Resource.UnitToString(res.Unit)});
        //                dgwResources.Rows[dgwResources.Rows.Count - 1].Tag = res;
        //            }
        //        }
        //        if (dgwResources.Rows.Count > 0)
        //        {
        //            dgwResources.CurrentCell = dgwResources.Rows[0].Cells[0];
        //            dgwResources_SelectionChanged(dgwResources, EventArgs.Empty);
        //        }
        //    }
        //}

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
    }
}
