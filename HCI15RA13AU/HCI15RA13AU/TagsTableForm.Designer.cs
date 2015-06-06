namespace HCI15RA13AU
{
    partial class TagsTableForm
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
            this.gbxTag = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtTagDesc = new System.Windows.Forms.TextBox();
            this.lblTagDesc = new System.Windows.Forms.Label();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.btnEditTag = new System.Windows.Forms.Button();
            this.btnNewTag = new System.Windows.Forms.Button();
            this.dgwTags = new System.Windows.Forms.DataGridView();
            this.TagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbxTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTags)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTag
            // 
            this.gbxTag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxTag.Controls.Add(this.txtColor);
            this.gbxTag.Controls.Add(this.lblColor);
            this.gbxTag.Controls.Add(this.txtTagDesc);
            this.gbxTag.Controls.Add(this.lblTagDesc);
            this.gbxTag.Location = new System.Drawing.Point(12, 382);
            this.gbxTag.Name = "gbxTag";
            this.gbxTag.Size = new System.Drawing.Size(430, 242);
            this.gbxTag.TabIndex = 19;
            this.gbxTag.TabStop = false;
            this.gbxTag.Text = "Detalji o etiketi";
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(122, 165);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(279, 56);
            this.txtColor.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(20, 183);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(85, 18);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Boja etikete";
            // 
            // txtTagDesc
            // 
            this.txtTagDesc.Location = new System.Drawing.Point(122, 32);
            this.txtTagDesc.Multiline = true;
            this.txtTagDesc.Name = "txtTagDesc";
            this.txtTagDesc.ReadOnly = true;
            this.txtTagDesc.Size = new System.Drawing.Size(279, 104);
            this.txtTagDesc.TabIndex = 1;
            // 
            // lblTagDesc
            // 
            this.lblTagDesc.AutoSize = true;
            this.lblTagDesc.Location = new System.Drawing.Point(20, 35);
            this.lblTagDesc.Name = "lblTagDesc";
            this.lblTagDesc.Size = new System.Drawing.Size(39, 18);
            this.lblTagDesc.TabIndex = 0;
            this.lblTagDesc.Text = "Opis";
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.Location = new System.Drawing.Point(331, 90);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(111, 32);
            this.btnDeleteTag.TabIndex = 17;
            this.btnDeleteTag.Text = "Obriši etiketu";
            this.btnDeleteTag.UseVisualStyleBackColor = true;
            this.btnDeleteTag.Click += new System.EventHandler(this.btnDeleteTag_Click);
            // 
            // btnEditTag
            // 
            this.btnEditTag.Location = new System.Drawing.Point(331, 52);
            this.btnEditTag.Name = "btnEditTag";
            this.btnEditTag.Size = new System.Drawing.Size(111, 32);
            this.btnEditTag.TabIndex = 16;
            this.btnEditTag.Text = "Izmeni etiketu";
            this.btnEditTag.UseVisualStyleBackColor = true;
            this.btnEditTag.Click += new System.EventHandler(this.btnEditTag_Click);
            // 
            // btnNewTag
            // 
            this.btnNewTag.Location = new System.Drawing.Point(331, 14);
            this.btnNewTag.Name = "btnNewTag";
            this.btnNewTag.Size = new System.Drawing.Size(111, 32);
            this.btnNewTag.TabIndex = 15;
            this.btnNewTag.Text = "Dodaj etiketu";
            this.btnNewTag.UseVisualStyleBackColor = true;
            this.btnNewTag.Click += new System.EventHandler(this.btnNewTag_Click);
            // 
            // dgwTags
            // 
            this.dgwTags.AllowUserToAddRows = false;
            this.dgwTags.AllowUserToDeleteRows = false;
            this.dgwTags.AllowUserToResizeRows = false;
            this.dgwTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TagID,
            this.TagColor});
            this.dgwTags.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwTags.Location = new System.Drawing.Point(12, 12);
            this.dgwTags.Name = "dgwTags";
            this.dgwTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTags.Size = new System.Drawing.Size(244, 364);
            this.dgwTags.TabIndex = 18;
            this.dgwTags.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTags_CellContentClick);
            this.dgwTags.SelectionChanged += new System.EventHandler(this.dgwTags_SelectionChanged);
            // 
            // TagID
            // 
            this.TagID.HeaderText = "ID";
            this.TagID.Name = "TagID";
            // 
            // TagColor
            // 
            this.TagColor.HeaderText = "Boja";
            this.TagColor.Name = "TagColor";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "../../help/help project.chm";
            // 
            // TagsTableForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(459, 636);
            this.Controls.Add(this.gbxTag);
            this.Controls.Add(this.btnDeleteTag);
            this.Controls.Add(this.btnEditTag);
            this.Controls.Add(this.btnNewTag);
            this.Controls.Add(this.dgwTags);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this, "Etiketa");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "TagsTableForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Tabela etiketa";
            this.Load += new System.EventHandler(this.TagsTable_Load);
            this.gbxTag.ResumeLayout(false);
            this.gbxTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTag;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtTagDesc;
        private System.Windows.Forms.Label lblTagDesc;
        private System.Windows.Forms.Button btnDeleteTag;
        private System.Windows.Forms.Button btnEditTag;
        private System.Windows.Forms.Button btnNewTag;
        private System.Windows.Forms.DataGridView dgwTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagColor;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}