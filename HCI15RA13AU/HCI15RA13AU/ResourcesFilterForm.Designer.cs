namespace HCI15RA13AU
{
    partial class ResourcesFilterForm
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
            this.components = new System.ComponentModel.Container();
            this.chbID = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.chbCost = new System.Windows.Forms.CheckBox();
            this.chbImportant = new System.Windows.Forms.CheckBox();
            this.chbRenewable = new System.Windows.Forms.CheckBox();
            this.chbFrequency = new System.Windows.Forms.CheckBox();
            this.chbUnit = new System.Windows.Forms.CheckBox();
            this.dgwResources = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Important = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Renewable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpMax = new System.Windows.Forms.DateTimePicker();
            this.dtpMin = new System.Windows.Forms.DateTimePicker();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.chbIsImportant = new System.Windows.Forms.CheckBox();
            this.chbIsRenewable = new System.Windows.Forms.CheckBox();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtCostMin = new System.Windows.Forms.TextBox();
            this.txtCostMax = new System.Windows.Forms.TextBox();
            this.lblCost1 = new System.Windows.Forms.Label();
            this.lblCost2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.chbType = new System.Windows.Forms.CheckBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.chbTags = new System.Windows.Forms.CheckBox();
            this.btnTags = new System.Windows.Forms.Button();
            this.pnlTags = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDateMin = new System.Windows.Forms.TextBox();
            this.txtDateMax = new System.Windows.Forms.TextBox();
            this.rbtDateMin1 = new System.Windows.Forms.RadioButton();
            this.rbtDateMin2 = new System.Windows.Forms.RadioButton();
            this.rbtDateMax1 = new System.Windows.Forms.RadioButton();
            this.rbtDateMax2 = new System.Windows.Forms.RadioButton();
            this.lblApprox = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.epDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDate)).BeginInit();
            this.SuspendLayout();
            // 
            // chbID
            // 
            this.chbID.AutoSize = true;
            this.chbID.Location = new System.Drawing.Point(897, 13);
            this.chbID.Name = "chbID";
            this.chbID.Size = new System.Drawing.Size(79, 22);
            this.chbID.TabIndex = 0;
            this.chbID.Text = "Oznaka";
            this.chbID.UseVisualStyleBackColor = true;
            this.chbID.CheckedChanged += new System.EventHandler(this.chbID_CheckedChanged);
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Location = new System.Drawing.Point(1040, 12);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(64, 22);
            this.chbName.TabIndex = 1;
            this.chbName.Text = "Naziv";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Location = new System.Drawing.Point(897, 66);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(71, 22);
            this.chbDate.TabIndex = 2;
            this.chbDate.Text = "Datum";
            this.chbDate.UseVisualStyleBackColor = true;
            this.chbDate.CheckedChanged += new System.EventHandler(this.chbDate_CheckedChanged);
            // 
            // chbCost
            // 
            this.chbCost.AutoSize = true;
            this.chbCost.Location = new System.Drawing.Point(897, 375);
            this.chbCost.Name = "chbCost";
            this.chbCost.Size = new System.Drawing.Size(145, 22);
            this.chbCost.TabIndex = 3;
            this.chbCost.Text = "Cena (u dolarima)";
            this.chbCost.UseVisualStyleBackColor = true;
            this.chbCost.CheckedChanged += new System.EventHandler(this.chbCost_CheckedChanged);
            // 
            // chbImportant
            // 
            this.chbImportant.AutoSize = true;
            this.chbImportant.Location = new System.Drawing.Point(897, 213);
            this.chbImportant.Name = "chbImportant";
            this.chbImportant.Size = new System.Drawing.Size(146, 22);
            this.chbImportant.TabIndex = 4;
            this.chbImportant.Text = "Strateška važnost";
            this.chbImportant.UseVisualStyleBackColor = true;
            this.chbImportant.CheckedChanged += new System.EventHandler(this.chbImportant_CheckedChanged);
            // 
            // chbRenewable
            // 
            this.chbRenewable.AutoSize = true;
            this.chbRenewable.Location = new System.Drawing.Point(1040, 213);
            this.chbRenewable.Name = "chbRenewable";
            this.chbRenewable.Size = new System.Drawing.Size(108, 22);
            this.chbRenewable.TabIndex = 5;
            this.chbRenewable.Text = "Obnovljivost";
            this.chbRenewable.UseVisualStyleBackColor = true;
            this.chbRenewable.CheckedChanged += new System.EventHandler(this.chbRenewable_CheckedChanged);
            // 
            // chbFrequency
            // 
            this.chbFrequency.AutoSize = true;
            this.chbFrequency.Location = new System.Drawing.Point(897, 293);
            this.chbFrequency.Name = "chbFrequency";
            this.chbFrequency.Size = new System.Drawing.Size(102, 22);
            this.chbFrequency.TabIndex = 6;
            this.chbFrequency.Text = "Frekvencija";
            this.chbFrequency.UseVisualStyleBackColor = true;
            this.chbFrequency.CheckedChanged += new System.EventHandler(this.chbFrequency_CheckedChanged);
            // 
            // chbUnit
            // 
            this.chbUnit.AutoSize = true;
            this.chbUnit.Location = new System.Drawing.Point(1040, 293);
            this.chbUnit.Name = "chbUnit";
            this.chbUnit.Size = new System.Drawing.Size(119, 22);
            this.chbUnit.TabIndex = 7;
            this.chbUnit.Text = "Jedinica mere";
            this.chbUnit.UseVisualStyleBackColor = true;
            this.chbUnit.CheckedChanged += new System.EventHandler(this.chbUnit_CheckedChanged);
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
            this.dgwResources.Size = new System.Drawing.Size(845, 605);
            this.dgwResources.TabIndex = 70;
            this.dgwResources.SelectionChanged += new System.EventHandler(this.dgwResources_SelectionChanged);
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
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(897, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 24);
            this.txtID.TabIndex = 71;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1040, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 24);
            this.txtName.TabIndex = 72;
            // 
            // dtpMax
            // 
            this.dtpMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMax.Location = new System.Drawing.Point(56, 6);
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.Size = new System.Drawing.Size(89, 24);
            this.dtpMax.TabIndex = 74;
            // 
            // dtpMin
            // 
            this.dtpMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMin.Location = new System.Drawing.Point(58, 6);
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.Size = new System.Drawing.Size(89, 24);
            this.dtpMin.TabIndex = 75;
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(7, 9);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(32, 18);
            this.lblDate1.TabIndex = 76;
            this.lblDate1.Text = "Od:";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(5, 9);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(32, 18);
            this.lblDate2.TabIndex = 77;
            this.lblDate2.Text = "Do:";
            // 
            // chbIsImportant
            // 
            this.chbIsImportant.AutoSize = true;
            this.chbIsImportant.Location = new System.Drawing.Point(929, 241);
            this.chbIsImportant.Name = "chbIsImportant";
            this.chbIsImportant.Size = new System.Drawing.Size(68, 22);
            this.chbIsImportant.TabIndex = 78;
            this.chbIsImportant.Text = "Važan";
            this.chbIsImportant.UseVisualStyleBackColor = true;
            // 
            // chbIsRenewable
            // 
            this.chbIsRenewable.AutoSize = true;
            this.chbIsRenewable.Location = new System.Drawing.Point(1053, 241);
            this.chbIsRenewable.Name = "chbIsRenewable";
            this.chbIsRenewable.Size = new System.Drawing.Size(87, 22);
            this.chbIsRenewable.TabIndex = 79;
            this.chbIsRenewable.Text = "Obnovljiv";
            this.chbIsRenewable.UseVisualStyleBackColor = true;
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Items.AddRange(new object[] {
            "redak",
            "čest",
            "univerzalan"});
            this.cmbFrequency.Location = new System.Drawing.Point(897, 316);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(121, 26);
            this.cmbFrequency.TabIndex = 80;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "merica",
            "barel",
            "tona",
            "kilogram"});
            this.cmbUnit.Location = new System.Drawing.Point(1040, 316);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(119, 26);
            this.cmbUnit.TabIndex = 81;
            // 
            // txtCostMin
            // 
            this.txtCostMin.Location = new System.Drawing.Point(897, 421);
            this.txtCostMin.Name = "txtCostMin";
            this.txtCostMin.Size = new System.Drawing.Size(121, 24);
            this.txtCostMin.TabIndex = 82;
            // 
            // txtCostMax
            // 
            this.txtCostMax.Location = new System.Drawing.Point(897, 469);
            this.txtCostMax.Name = "txtCostMax";
            this.txtCostMax.Size = new System.Drawing.Size(121, 24);
            this.txtCostMax.TabIndex = 83;
            // 
            // lblCost1
            // 
            this.lblCost1.AutoSize = true;
            this.lblCost1.Location = new System.Drawing.Point(894, 400);
            this.lblCost1.Name = "lblCost1";
            this.lblCost1.Size = new System.Drawing.Size(32, 18);
            this.lblCost1.TabIndex = 84;
            this.lblCost1.Text = "Od:";
            // 
            // lblCost2
            // 
            this.lblCost2.AutoSize = true;
            this.lblCost2.Location = new System.Drawing.Point(894, 448);
            this.lblCost2.Name = "lblCost2";
            this.lblCost2.Size = new System.Drawing.Size(32, 18);
            this.lblCost2.TabIndex = 85;
            this.lblCost2.Text = "Do:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(892, 578);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 40);
            this.btnFilter.TabIndex = 86;
            this.btnFilter.Text = "Primeni";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // chbType
            // 
            this.chbType.AutoSize = true;
            this.chbType.Location = new System.Drawing.Point(1040, 375);
            this.chbType.Name = "chbType";
            this.chbType.Size = new System.Drawing.Size(101, 22);
            this.chbType.TabIndex = 87;
            this.chbType.Text = "Tip resursa";
            this.chbType.UseVisualStyleBackColor = true;
            this.chbType.CheckedChanged += new System.EventHandler(this.chbType_CheckedChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(1038, 421);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 26);
            this.cmbType.TabIndex = 88;
            // 
            // chbTags
            // 
            this.chbTags.AutoSize = true;
            this.chbTags.Location = new System.Drawing.Point(897, 499);
            this.chbTags.Name = "chbTags";
            this.chbTags.Size = new System.Drawing.Size(72, 22);
            this.chbTags.TabIndex = 89;
            this.chbTags.Text = "Etikete";
            this.chbTags.UseVisualStyleBackColor = true;
            this.chbTags.CheckedChanged += new System.EventHandler(this.chbTags_CheckedChanged);
            // 
            // btnTags
            // 
            this.btnTags.Location = new System.Drawing.Point(929, 527);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(75, 30);
            this.btnTags.TabIndex = 90;
            this.btnTags.Text = "Izaberi";
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // pnlTags
            // 
            this.pnlTags.AutoScroll = true;
            this.pnlTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTags.Location = new System.Drawing.Point(1037, 453);
            this.pnlTags.Name = "pnlTags";
            this.pnlTags.Size = new System.Drawing.Size(122, 104);
            this.pnlTags.TabIndex = 92;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(983, 578);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 40);
            this.btnOK.TabIndex = 94;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1075, 578);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 40);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDateMin
            // 
            this.txtDateMin.Location = new System.Drawing.Point(173, 6);
            this.txtDateMin.Name = "txtDateMin";
            this.txtDateMin.Size = new System.Drawing.Size(99, 24);
            this.txtDateMin.TabIndex = 96;
            this.txtDateMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtDateMin_Validating);
            // 
            // txtDateMax
            // 
            this.txtDateMax.Location = new System.Drawing.Point(171, 6);
            this.txtDateMax.Name = "txtDateMax";
            this.txtDateMax.Size = new System.Drawing.Size(99, 24);
            this.txtDateMax.TabIndex = 97;
            this.txtDateMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtDateMax_Validating);
            // 
            // rbtDateMin1
            // 
            this.rbtDateMin1.AutoSize = true;
            this.rbtDateMin1.Location = new System.Drawing.Point(38, 12);
            this.rbtDateMin1.Name = "rbtDateMin1";
            this.rbtDateMin1.Size = new System.Drawing.Size(14, 13);
            this.rbtDateMin1.TabIndex = 98;
            this.rbtDateMin1.TabStop = true;
            this.rbtDateMin1.UseVisualStyleBackColor = true;
            this.rbtDateMin1.CheckedChanged += new System.EventHandler(this.rbtDateMin1_CheckedChanged);
            // 
            // rbtDateMin2
            // 
            this.rbtDateMin2.AutoSize = true;
            this.rbtDateMin2.Location = new System.Drawing.Point(153, 12);
            this.rbtDateMin2.Name = "rbtDateMin2";
            this.rbtDateMin2.Size = new System.Drawing.Size(14, 13);
            this.rbtDateMin2.TabIndex = 99;
            this.rbtDateMin2.TabStop = true;
            this.rbtDateMin2.UseVisualStyleBackColor = true;
            // 
            // rbtDateMax1
            // 
            this.rbtDateMax1.AutoSize = true;
            this.rbtDateMax1.Location = new System.Drawing.Point(36, 12);
            this.rbtDateMax1.Name = "rbtDateMax1";
            this.rbtDateMax1.Size = new System.Drawing.Size(14, 13);
            this.rbtDateMax1.TabIndex = 100;
            this.rbtDateMax1.TabStop = true;
            this.rbtDateMax1.UseVisualStyleBackColor = true;
            this.rbtDateMax1.CheckedChanged += new System.EventHandler(this.rbtDateMax1_CheckedChanged);
            // 
            // rbtDateMax2
            // 
            this.rbtDateMax2.AutoSize = true;
            this.rbtDateMax2.Location = new System.Drawing.Point(151, 12);
            this.rbtDateMax2.Name = "rbtDateMax2";
            this.rbtDateMax2.Size = new System.Drawing.Size(14, 13);
            this.rbtDateMax2.TabIndex = 101;
            this.rbtDateMax2.TabStop = true;
            this.rbtDateMax2.UseVisualStyleBackColor = true;
            this.rbtDateMax2.CheckedChanged += new System.EventHandler(this.rbtDateMax2_CheckedChanged);
            // 
            // lblApprox
            // 
            this.lblApprox.AutoSize = true;
            this.lblApprox.Location = new System.Drawing.Point(1057, 91);
            this.lblApprox.Name = "lblApprox";
            this.lblApprox.Size = new System.Drawing.Size(64, 18);
            this.lblApprox.TabIndex = 102;
            this.lblApprox.Text = "Okvirno:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(942, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 18);
            this.lblDate.TabIndex = 103;
            this.lblDate.Text = "Tačno:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtDateMin2);
            this.panel1.Controls.Add(this.rbtDateMin1);
            this.panel1.Controls.Add(this.txtDateMin);
            this.panel1.Controls.Add(this.lblDate1);
            this.panel1.Controls.Add(this.dtpMin);
            this.panel1.Location = new System.Drawing.Point(887, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 40);
            this.panel1.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtDateMax2);
            this.panel2.Controls.Add(this.rbtDateMax1);
            this.panel2.Controls.Add(this.txtDateMax);
            this.panel2.Controls.Add(this.lblDate2);
            this.panel2.Controls.Add(this.dtpMax);
            this.panel2.Location = new System.Drawing.Point(889, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 40);
            this.panel2.TabIndex = 105;
            // 
            // epDate
            // 
            this.epDate.ContainerControl = this;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "../../help/help project.chm";
            // 
            // ResourcesFilterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblApprox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlTags);
            this.Controls.Add(this.btnTags);
            this.Controls.Add(this.chbTags);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.chbType);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblCost2);
            this.Controls.Add(this.lblCost1);
            this.Controls.Add(this.txtCostMax);
            this.Controls.Add(this.txtCostMin);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbFrequency);
            this.Controls.Add(this.chbIsRenewable);
            this.Controls.Add(this.chbIsImportant);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgwResources);
            this.Controls.Add(this.chbUnit);
            this.Controls.Add(this.chbFrequency);
            this.Controls.Add(this.chbRenewable);
            this.Controls.Add(this.chbImportant);
            this.Controls.Add(this.chbCost);
            this.Controls.Add(this.chbDate);
            this.Controls.Add(this.chbName);
            this.Controls.Add(this.chbID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this, "Pretraga");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.MaximizeBox = false;
            this.Name = "ResourcesFilterForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Filtriranje resursa";
            this.Load += new System.EventHandler(this.ResourcesFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbID;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.CheckBox chbCost;
        private System.Windows.Forms.CheckBox chbImportant;
        private System.Windows.Forms.CheckBox chbRenewable;
        private System.Windows.Forms.CheckBox chbFrequency;
        private System.Windows.Forms.CheckBox chbUnit;
        private System.Windows.Forms.DataGridView dgwResources;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Important;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Renewable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpMax;
        private System.Windows.Forms.DateTimePicker dtpMin;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.CheckBox chbIsImportant;
        private System.Windows.Forms.CheckBox chbIsRenewable;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtCostMin;
        private System.Windows.Forms.TextBox txtCostMax;
        private System.Windows.Forms.Label lblCost1;
        private System.Windows.Forms.Label lblCost2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox chbType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.CheckBox chbTags;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Panel pnlTags;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDateMin;
        private System.Windows.Forms.TextBox txtDateMax;
        private System.Windows.Forms.RadioButton rbtDateMin1;
        private System.Windows.Forms.RadioButton rbtDateMin2;
        private System.Windows.Forms.RadioButton rbtDateMax1;
        private System.Windows.Forms.RadioButton rbtDateMax2;
        private System.Windows.Forms.Label lblApprox;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider epDate;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}