namespace HCI15RA13AU
{
    partial class TypesTable
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
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.pbxTypeIcon = new System.Windows.Forms.PictureBox();
            this.txtTypeDesc = new System.Windows.Forms.TextBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblTypeDesc = new System.Windows.Forms.Label();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnEditType = new System.Windows.Forms.Button();
            this.btnNewType = new System.Windows.Forms.Button();
            this.dgwTypes = new System.Windows.Forms.DataGridView();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTypeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxType
            // 
            this.gbxType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxType.Controls.Add(this.pbxTypeIcon);
            this.gbxType.Controls.Add(this.txtTypeDesc);
            this.gbxType.Controls.Add(this.lblIcon);
            this.gbxType.Controls.Add(this.lblTypeDesc);
            this.gbxType.Location = new System.Drawing.Point(12, 382);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(430, 242);
            this.gbxType.TabIndex = 18;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Detalji o tipu";
            // 
            // pbxTypeIcon
            // 
            this.pbxTypeIcon.Location = new System.Drawing.Point(97, 153);
            this.pbxTypeIcon.Name = "pbxTypeIcon";
            this.pbxTypeIcon.Size = new System.Drawing.Size(100, 83);
            this.pbxTypeIcon.TabIndex = 3;
            this.pbxTypeIcon.TabStop = false;
            // 
            // txtTypeDesc
            // 
            this.txtTypeDesc.Location = new System.Drawing.Point(97, 32);
            this.txtTypeDesc.Multiline = true;
            this.txtTypeDesc.Name = "txtTypeDesc";
            this.txtTypeDesc.ReadOnly = true;
            this.txtTypeDesc.Size = new System.Drawing.Size(302, 104);
            this.txtTypeDesc.TabIndex = 2;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(18, 183);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(55, 18);
            this.lblIcon.TabIndex = 1;
            this.lblIcon.Text = "Ikonica";
            // 
            // lblTypeDesc
            // 
            this.lblTypeDesc.AutoSize = true;
            this.lblTypeDesc.Location = new System.Drawing.Point(18, 35);
            this.lblTypeDesc.Name = "lblTypeDesc";
            this.lblTypeDesc.Size = new System.Drawing.Size(39, 18);
            this.lblTypeDesc.TabIndex = 0;
            this.lblTypeDesc.Text = "Opis";
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Location = new System.Drawing.Point(352, 90);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(90, 32);
            this.btnDeleteType.TabIndex = 16;
            this.btnDeleteType.Text = "Obriši tip";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // btnEditType
            // 
            this.btnEditType.Location = new System.Drawing.Point(352, 52);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(90, 32);
            this.btnEditType.TabIndex = 15;
            this.btnEditType.Text = "Izmeni tip";
            this.btnEditType.UseVisualStyleBackColor = true;
            this.btnEditType.Click += new System.EventHandler(this.btnEditType_Click);
            // 
            // btnNewType
            // 
            this.btnNewType.Location = new System.Drawing.Point(352, 14);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(90, 32);
            this.btnNewType.TabIndex = 14;
            this.btnNewType.Text = "Dodaj tip";
            this.btnNewType.UseVisualStyleBackColor = true;
            this.btnNewType.Click += new System.EventHandler(this.btnNewType_Click);
            // 
            // dgwTypes
            // 
            this.dgwTypes.AllowUserToAddRows = false;
            this.dgwTypes.AllowUserToDeleteRows = false;
            this.dgwTypes.AllowUserToResizeRows = false;
            this.dgwTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.TypeName});
            this.dgwTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwTypes.Location = new System.Drawing.Point(12, 12);
            this.dgwTypes.Name = "dgwTypes";
            this.dgwTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTypes.Size = new System.Drawing.Size(243, 364);
            this.dgwTypes.TabIndex = 17;
            this.dgwTypes.SelectionChanged += new System.EventHandler(this.dgwTypes_SelectionChanged);
            // 
            // TypeID
            // 
            this.TypeID.HeaderText = "ID";
            this.TypeID.Name = "TypeID";
            // 
            // TypeName
            // 
            this.TypeName.HeaderText = "Naziv";
            this.TypeName.Name = "TypeName";
            // 
            // TypesTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(459, 636);
            this.Controls.Add(this.gbxType);
            this.Controls.Add(this.btnDeleteType);
            this.Controls.Add(this.btnEditType);
            this.Controls.Add(this.btnNewType);
            this.Controls.Add(this.dgwTypes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TypesTable";
            this.Text = "Tabela tipova resursa";
            this.Load += new System.EventHandler(this.TypesTable_Load);
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTypeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.PictureBox pbxTypeIcon;
        private System.Windows.Forms.TextBox txtTypeDesc;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTypeDesc;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.DataGridView dgwTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
    }
}