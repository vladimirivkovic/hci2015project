﻿namespace HCI15RA13AU
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelectedResource = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbDetails = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectedResource
            // 
            this.lblSelectedResource.AutoSize = true;
            this.lblSelectedResource.Location = new System.Drawing.Point(71, 533);
            this.lblSelectedResource.Name = "lblSelectedResource";
            this.lblSelectedResource.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedResource.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 714);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1009, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mapa";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(810, 500);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grbDetails);
            this.tabPage2.Controls.Add(this.btnEditResource);
            this.tabPage2.Controls.Add(this.btnAddResource);
            this.tabPage2.Controls.Add(this.dgwResources);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1009, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabelarni prikaz";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.grbDetails.Location = new System.Drawing.Point(6, 418);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(829, 178);
            this.grbDetails.TabIndex = 14;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Detalji";
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
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(103, 132);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 9;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(103, 91);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.ReadOnly = true;
            this.txtFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtFrequency.TabIndex = 8;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 54);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
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
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // btnEditResource
            // 
            this.btnEditResource.Location = new System.Drawing.Point(732, 51);
            this.btnEditResource.Name = "btnEditResource";
            this.btnEditResource.Size = new System.Drawing.Size(75, 23);
            this.btnEditResource.TabIndex = 13;
            this.btnEditResource.Text = "Izmeni resurs";
            this.btnEditResource.UseVisualStyleBackColor = true;
            this.btnEditResource.Click += new System.EventHandler(this.btnEditResource_Click_1);
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(732, 7);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(75, 23);
            this.btnAddResource.TabIndex = 12;
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
            this.Renewable});
            this.dgwResources.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwResources.Location = new System.Drawing.Point(6, 6);
            this.dgwResources.Name = "dgwResources";
            this.dgwResources.ReadOnly = true;
            this.dgwResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwResources.Size = new System.Drawing.Size(635, 390);
            this.dgwResources.TabIndex = 11;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 728);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblSelectedResource);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Mapa svetskih resursa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelectedResource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grbDetails;
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

    }
}

