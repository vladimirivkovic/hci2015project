namespace HCI15RA13AU
{
    partial class TableView
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
            this.dgwResources = new System.Windows.Forms.DataGridView();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.btnEditResource = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).BeginInit();
            this.grbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwResources
            // 
            this.dgwResources.AllowUserToAddRows = false;
            this.dgwResources.AllowUserToDeleteRows = false;
            this.dgwResources.AllowUserToResizeRows = false;
            this.dgwResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResources.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwResources.Location = new System.Drawing.Point(12, 12);
            this.dgwResources.Name = "dgwResources";
            this.dgwResources.ReadOnly = true;
            this.dgwResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwResources.Size = new System.Drawing.Size(635, 390);
            this.dgwResources.TabIndex = 0;
            this.dgwResources.SelectionChanged += new System.EventHandler(this.dgwResources_SelectionChanged);
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(738, 13);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(75, 23);
            this.btnAddResource.TabIndex = 1;
            this.btnAddResource.Text = "Dodaj resurs";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // btnEditResource
            // 
            this.btnEditResource.Location = new System.Drawing.Point(738, 57);
            this.btnEditResource.Name = "btnEditResource";
            this.btnEditResource.Size = new System.Drawing.Size(75, 23);
            this.btnEditResource.TabIndex = 2;
            this.btnEditResource.Text = "Izmeni resurs";
            this.btnEditResource.UseVisualStyleBackColor = true;
            this.btnEditResource.Click += new System.EventHandler(this.btnEditResource_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.lblUnit);
            this.grbDetails.Controls.Add(this.txtUnit);
            this.grbDetails.Controls.Add(this.txtFrequency);
            this.grbDetails.Controls.Add(this.lblFrequency);
            this.grbDetails.Controls.Add(this.txtName);
            this.grbDetails.Controls.Add(this.lblName);
            this.grbDetails.Controls.Add(this.lblId);
            this.grbDetails.Controls.Add(this.txtId);
            this.grbDetails.Location = new System.Drawing.Point(12, 424);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(829, 178);
            this.grbDetails.TabIndex = 4;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Detalji";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Naziv";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 54);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(18, 94);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(62, 13);
            this.lblFrequency.TabIndex = 7;
            this.lblFrequency.Text = "Frekvencija";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(103, 91);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.ReadOnly = true;
            this.txtFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtFrequency.TabIndex = 8;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(103, 132);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 9;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(18, 135);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(72, 13);
            this.lblUnit.TabIndex = 10;
            this.lblUnit.Text = "Jedinica mere";
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 614);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.btnEditResource);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.dgwResources);
            this.Name = "TableView";
            this.Text = "TableView";
            this.Load += new System.EventHandler(this.TableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).EndInit();
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwResources;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.Button btnEditResource;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
    }
}