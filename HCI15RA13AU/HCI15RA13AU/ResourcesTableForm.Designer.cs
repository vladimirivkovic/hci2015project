namespace HCI15RA13AU
{
    partial class ResourcesTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.pnlTags = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtTypeId = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblTypeId = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.tag3 = new System.Windows.Forms.Label();
            this.tag2 = new System.Windows.Forms.Label();
            this.tag1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDesription = new System.Windows.Forms.Label();
            this.chbExploatable = new System.Windows.Forms.CheckBox();
            this.chbImportant = new System.Windows.Forms.CheckBox();
            this.chbRenewable = new System.Windows.Forms.CheckBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEditResource = new System.Windows.Forms.Button();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.dgwResources = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Important = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Renewable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilter = new System.Windows.Forms.Button();
            this.chbId = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.chbType = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.grbDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.Location = new System.Drawing.Point(1081, 169);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 18);
            this.lblSearch.TabIndex = 72;
            this.lblSearch.Text = "Filtriranje po:";
            // 
            // txtSearch
            // 
            this.helpProvider1.SetHelpKeyword(this.txtSearch, "Pretraga");
            this.helpProvider1.SetHelpNavigator(this.txtSearch, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.txtSearch.Location = new System.Drawing.Point(925, 218);
            this.txtSearch.Name = "txtSearch";
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.txtSearch.Size = new System.Drawing.Size(248, 24);
            this.txtSearch.TabIndex = 68;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pbxIcon
            // 
            this.pbxIcon.Location = new System.Drawing.Point(1023, 248);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(150, 150);
            this.pbxIcon.TabIndex = 71;
            this.pbxIcon.TabStop = false;
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteResource.Location = new System.Drawing.Point(1061, 98);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(112, 32);
            this.btnDeleteResource.TabIndex = 67;
            this.btnDeleteResource.Text = "Obriši resurs";
            this.btnDeleteResource.UseVisualStyleBackColor = true;
            this.btnDeleteResource.Click += new System.EventHandler(this.btnDeleteResource_Click);
            // 
            // grbDetails
            // 
            this.grbDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbDetails.Controls.Add(this.pnlTags);
            this.grbDetails.Controls.Add(this.groupBox1);
            this.grbDetails.Controls.Add(this.lblTags);
            this.grbDetails.Controls.Add(this.tag3);
            this.grbDetails.Controls.Add(this.tag2);
            this.grbDetails.Controls.Add(this.tag1);
            this.grbDetails.Controls.Add(this.txtDescription);
            this.grbDetails.Controls.Add(this.lblDesription);
            this.grbDetails.Controls.Add(this.chbExploatable);
            this.grbDetails.Controls.Add(this.chbImportant);
            this.grbDetails.Controls.Add(this.chbRenewable);
            this.grbDetails.Controls.Add(this.lblUnit);
            this.grbDetails.Controls.Add(this.txtUnit);
            this.grbDetails.Controls.Add(this.txtFrequency);
            this.grbDetails.Controls.Add(this.lblFrequency);
            this.grbDetails.Controls.Add(this.txtName);
            this.grbDetails.Controls.Add(this.lblName);
            this.grbDetails.Controls.Add(this.lblId);
            this.grbDetails.Controls.Add(this.txtId);
            this.grbDetails.Location = new System.Drawing.Point(13, 405);
            this.grbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grbDetails.Size = new System.Drawing.Size(1160, 230);
            this.grbDetails.TabIndex = 70;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Detalji";
            // 
            // pnlTags
            // 
            this.pnlTags.AutoScroll = true;
            this.pnlTags.Location = new System.Drawing.Point(468, 177);
            this.pnlTags.Name = "pnlTags";
            this.pnlTags.Size = new System.Drawing.Size(180, 40);
            this.pnlTags.TabIndex = 93;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTypeName);
            this.groupBox1.Controls.Add(this.txtTypeId);
            this.groupBox1.Controls.Add(this.lblTypeName);
            this.groupBox1.Controls.Add(this.lblTypeId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(758, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 62);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip resursa";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(263, 28);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.ReadOnly = true;
            this.txtTypeName.Size = new System.Drawing.Size(100, 24);
            this.txtTypeName.TabIndex = 3;
            // 
            // txtTypeId
            // 
            this.txtTypeId.Location = new System.Drawing.Point(72, 29);
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.ReadOnly = true;
            this.txtTypeId.Size = new System.Drawing.Size(100, 24);
            this.txtTypeId.TabIndex = 2;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTypeName.Location = new System.Drawing.Point(212, 31);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(45, 18);
            this.lblTypeName.TabIndex = 1;
            this.lblTypeName.Text = "Naziv";
            // 
            // lblTypeId
            // 
            this.lblTypeId.AutoSize = true;
            this.lblTypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTypeId.Location = new System.Drawing.Point(6, 32);
            this.lblTypeId.Name = "lblTypeId";
            this.lblTypeId.Size = new System.Drawing.Size(60, 18);
            this.lblTypeId.TabIndex = 0;
            this.lblTypeId.Text = "Oznaka";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTags.Location = new System.Drawing.Point(405, 184);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(57, 18);
            this.lblTags.TabIndex = 59;
            this.lblTags.Text = "Etikete:";
            // 
            // tag3
            // 
            this.tag3.Location = new System.Drawing.Point(0, 0);
            this.tag3.Name = "tag3";
            this.tag3.Size = new System.Drawing.Size(100, 23);
            this.tag3.TabIndex = 0;
            // 
            // tag2
            // 
            this.tag2.Location = new System.Drawing.Point(0, 0);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(100, 23);
            this.tag2.TabIndex = 1;
            // 
            // tag1
            // 
            this.tag1.Location = new System.Drawing.Point(0, 0);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(100, 23);
            this.tag1.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(758, 26);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(369, 122);
            this.txtDescription.TabIndex = 53;
            // 
            // lblDesription
            // 
            this.lblDesription.AutoSize = true;
            this.lblDesription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDesription.Location = new System.Drawing.Point(663, 30);
            this.lblDesription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesription.Name = "lblDesription";
            this.lblDesription.Size = new System.Drawing.Size(39, 18);
            this.lblDesription.TabIndex = 52;
            this.lblDesription.Text = "Opis";
            // 
            // chbExploatable
            // 
            this.chbExploatable.AutoSize = true;
            this.chbExploatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExploatable.Location = new System.Drawing.Point(408, 128);
            this.chbExploatable.Margin = new System.Windows.Forms.Padding(4);
            this.chbExploatable.Name = "chbExploatable";
            this.chbExploatable.Size = new System.Drawing.Size(186, 22);
            this.chbExploatable.TabIndex = 51;
            this.chbExploatable.Text = "Moguća je ekspolatacija";
            this.chbExploatable.UseVisualStyleBackColor = true;
            // 
            // chbImportant
            // 
            this.chbImportant.AutoSize = true;
            this.chbImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbImportant.Location = new System.Drawing.Point(408, 78);
            this.chbImportant.Margin = new System.Windows.Forms.Padding(4);
            this.chbImportant.Name = "chbImportant";
            this.chbImportant.Size = new System.Drawing.Size(128, 22);
            this.chbImportant.TabIndex = 50;
            this.chbImportant.Text = "Strateški važan";
            this.chbImportant.UseVisualStyleBackColor = true;
            // 
            // chbRenewable
            // 
            this.chbRenewable.AutoSize = true;
            this.chbRenewable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRenewable.Location = new System.Drawing.Point(408, 28);
            this.chbRenewable.Margin = new System.Windows.Forms.Padding(4);
            this.chbRenewable.Name = "chbRenewable";
            this.chbRenewable.Size = new System.Drawing.Size(87, 22);
            this.chbRenewable.TabIndex = 49;
            this.chbRenewable.Text = "Obnovljiv";
            this.chbRenewable.UseVisualStyleBackColor = true;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnit.Location = new System.Drawing.Point(27, 187);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(100, 18);
            this.lblUnit.TabIndex = 10;
            this.lblUnit.Text = "Jedinica mere";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(154, 183);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(148, 24);
            this.txtUnit.TabIndex = 9;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(154, 126);
            this.txtFrequency.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.ReadOnly = true;
            this.txtFrequency.Size = new System.Drawing.Size(148, 24);
            this.txtFrequency.TabIndex = 8;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFrequency.Location = new System.Drawing.Point(27, 130);
            this.lblFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(83, 18);
            this.lblFrequency.TabIndex = 7;
            this.lblFrequency.Text = "Frekvencija";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(148, 24);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(27, 79);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 18);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Naziv";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblId.Location = new System.Drawing.Point(27, 30);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 18);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(154, 26);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(148, 24);
            this.txtId.TabIndex = 3;
            // 
            // btnEditResource
            // 
            this.btnEditResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditResource.Location = new System.Drawing.Point(1061, 59);
            this.btnEditResource.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditResource.Name = "btnEditResource";
            this.btnEditResource.Size = new System.Drawing.Size(112, 32);
            this.btnEditResource.TabIndex = 66;
            this.btnEditResource.Text = "Izmeni resurs";
            this.btnEditResource.UseVisualStyleBackColor = true;
            this.btnEditResource.Click += new System.EventHandler(this.btnEditResource_Click);
            // 
            // btnAddResource
            // 
            this.btnAddResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddResource.Location = new System.Drawing.Point(1061, 19);
            this.btnAddResource.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(112, 32);
            this.btnAddResource.TabIndex = 65;
            this.btnAddResource.Text = "Dodaj resurs";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // dgwResources
            // 
            this.dgwResources.AllowUserToAddRows = false;
            this.dgwResources.AllowUserToDeleteRows = false;
            this.dgwResources.AllowUserToResizeRows = false;
            this.dgwResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ResourceName,
            this.Date,
            this.Cost,
            this.Important,
            this.Renewable,
            this.Frequency,
            this.Unit});
            this.dgwResources.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwResources.Location = new System.Drawing.Point(13, 13);
            this.dgwResources.Margin = new System.Windows.Forms.Padding(4);
            this.dgwResources.Name = "dgwResources";
            this.dgwResources.ReadOnly = true;
            this.dgwResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwResources.Size = new System.Drawing.Size(845, 385);
            this.dgwResources.TabIndex = 69;
            this.dgwResources.SelectionChanged += new System.EventHandler(this.dgwResources_SelectionChanged);
            this.dgwResources.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgwResources_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ResourceName
            // 
            this.ResourceName.HeaderText = "Naziv";
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Datum";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cena";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Important
            // 
            this.Important.HeaderText = "Strateška važnost";
            this.Important.Name = "Important";
            this.Important.ReadOnly = true;
            this.Important.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Important.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Renewable
            // 
            this.Renewable.HeaderText = "Obnovljivost";
            this.Renewable.Name = "Renewable";
            this.Renewable.ReadOnly = true;
            this.Renewable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Renewable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frekvencija";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Jedinica mere";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(1061, 136);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 30);
            this.btnFilter.TabIndex = 73;
            this.btnFilter.Text = "Pretraga";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // chbId
            // 
            this.chbId.AutoSize = true;
            this.chbId.Location = new System.Drawing.Point(925, 190);
            this.chbId.Name = "chbId";
            this.chbId.Size = new System.Drawing.Size(71, 22);
            this.chbId.TabIndex = 75;
            this.chbId.Text = "oznaci";
            this.chbId.UseVisualStyleBackColor = true;
            this.chbId.CheckedChanged += new System.EventHandler(this.chbId_CheckedChanged);
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Location = new System.Drawing.Point(1002, 190);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(67, 22);
            this.chbName.TabIndex = 76;
            this.chbName.Text = "imenu";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // chbType
            // 
            this.chbType.AutoSize = true;
            this.chbType.Location = new System.Drawing.Point(1075, 190);
            this.chbType.Name = "chbType";
            this.chbType.Size = new System.Drawing.Size(98, 22);
            this.chbType.TabIndex = 77;
            this.chbType.Text = "oznaci tipa";
            this.chbType.UseVisualStyleBackColor = true;
            this.chbType.CheckedChanged += new System.EventHandler(this.chbType_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
            this.menuStrip1.TabIndex = 78;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "../../help/help project.chm";
            // 
            // ResourcesTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1202, 641);
            this.Controls.Add(this.chbType);
            this.Controls.Add(this.chbName);
            this.Controls.Add(this.chbId);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.btnDeleteResource);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.btnEditResource);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.dgwResources);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this, "Tabela resursa");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetHelpString(this, "");
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ResourcesTableForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Tabela resursa";
            this.Load += new System.EventHandler(this.ResourcesTable_Load);
            this.SizeChanged += new System.EventHandler(this.ResourcesTableForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtTypeId;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblTypeId;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label tag3;
        private System.Windows.Forms.Label tag2;
        private System.Windows.Forms.Label tag1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDesription;
        private System.Windows.Forms.CheckBox chbExploatable;
        private System.Windows.Forms.CheckBox chbImportant;
        private System.Windows.Forms.CheckBox chbRenewable;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEditResource;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.DataGridView dgwResources;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Important;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Renewable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel pnlTags;
        private System.Windows.Forms.CheckBox chbId;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.CheckBox chbType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}