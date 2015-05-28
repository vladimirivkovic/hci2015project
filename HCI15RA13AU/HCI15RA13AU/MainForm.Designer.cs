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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resursiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoviResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiketeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorijalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.pnlResources = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.lblUnmappedResources = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.btnEndTutorial = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectedResource
            // 
            this.lblSelectedResource.AutoSize = true;
            this.lblSelectedResource.Location = new System.Drawing.Point(106, 738);
            this.lblSelectedResource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedResource.Name = "lblSelectedResource";
            this.lblSelectedResource.Size = new System.Drawing.Size(0, 18);
            this.lblSelectedResource.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.tabeleToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.saveToolStripMenuItem.Text = "Sačuvaj";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.exitToolStripMenuItem.Text = "Izlaz";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabeleToolStripMenuItem
            // 
            this.tabeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resursiToolStripMenuItem,
            this.tipoviResursaToolStripMenuItem,
            this.etiketeToolStripMenuItem});
            this.tabeleToolStripMenuItem.Name = "tabeleToolStripMenuItem";
            this.tabeleToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.tabeleToolStripMenuItem.Text = "Tabele";
            // 
            // resursiToolStripMenuItem
            // 
            this.resursiToolStripMenuItem.Name = "resursiToolStripMenuItem";
            this.resursiToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.resursiToolStripMenuItem.Text = "Resursi";
            this.resursiToolStripMenuItem.Click += new System.EventHandler(this.resourcesToolStripMenuItem_Click);
            // 
            // tipoviResursaToolStripMenuItem
            // 
            this.tipoviResursaToolStripMenuItem.Name = "tipoviResursaToolStripMenuItem";
            this.tipoviResursaToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.tipoviResursaToolStripMenuItem.Text = "Tipovi resursa";
            this.tipoviResursaToolStripMenuItem.Click += new System.EventHandler(this.typesResursaToolStripMenuItem_Click);
            // 
            // etiketeToolStripMenuItem
            // 
            this.etiketeToolStripMenuItem.Name = "etiketeToolStripMenuItem";
            this.etiketeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.etiketeToolStripMenuItem.Text = "Etikete";
            this.etiketeToolStripMenuItem.Click += new System.EventHandler(this.tagsToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorijalToolStripMenuItem,
            this.pomoćToolStripMenuItem1});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // tutorijalToolStripMenuItem
            // 
            this.tutorijalToolStripMenuItem.Name = "tutorijalToolStripMenuItem";
            this.tutorijalToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.tutorijalToolStripMenuItem.Text = "Tutorijal";
            this.tutorijalToolStripMenuItem.Click += new System.EventHandler(this.tutorijalToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem1
            // 
            this.pomoćToolStripMenuItem1.Name = "pomoćToolStripMenuItem1";
            this.pomoćToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.pomoćToolStripMenuItem1.Text = "Help";
            this.pomoćToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.AllowDrop = true;
            this.pnlMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMap.BackgroundImage")));
            this.helpProvider.SetHelpKeyword(this.pnlMap, "");
            this.helpProvider.SetHelpNavigator(this.pnlMap, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.pnlMap.Location = new System.Drawing.Point(12, 61);
            this.pnlMap.Name = "pnlMap";
            this.helpProvider.SetShowHelp(this.pnlMap, true);
            this.pnlMap.Size = new System.Drawing.Size(901, 490);
            this.pnlMap.TabIndex = 13;
            this.pnlMap.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlMap_DragDrop);
            this.pnlMap.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlMap_DragEnter);
            this.pnlMap.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlMap_DragOver);
            this.pnlMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMap_MouseMove);
            // 
            // pnlResources
            // 
            this.pnlResources.AllowDrop = true;
            this.pnlResources.AutoScroll = true;
            this.pnlResources.Location = new System.Drawing.Point(922, 61);
            this.pnlResources.Name = "pnlResources";
            this.pnlResources.Size = new System.Drawing.Size(250, 609);
            this.pnlResources.TabIndex = 14;
            this.pnlResources.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlResources_DragDrop);
            this.pnlResources.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlResources_DragEnter);
            // 
            // pnlDelete
            // 
            this.pnlDelete.AllowDrop = true;
            this.pnlDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDelete.BackgroundImage")));
            this.pnlDelete.Location = new System.Drawing.Point(12, 557);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(110, 110);
            this.pnlDelete.TabIndex = 15;
            this.pnlDelete.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDelete_DragDrop);
            this.pnlDelete.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDelete_DragEnter);
            // 
            // lblUnmappedResources
            // 
            this.lblUnmappedResources.AutoSize = true;
            this.lblUnmappedResources.Location = new System.Drawing.Point(919, 31);
            this.lblUnmappedResources.Name = "lblUnmappedResources";
            this.lblUnmappedResources.Size = new System.Drawing.Size(132, 18);
            this.lblUnmappedResources.TabIndex = 16;
            this.lblUnmappedResources.Text = "Nemapirani resursi";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCoordinates,
            this.lblMessage});
            this.statusStrip.Location = new System.Drawing.Point(0, 673);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(0, 17);
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTutorial.Location = new System.Drawing.Point(189, 554);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(0, 31);
            this.lblTutorial.TabIndex = 18;
            // 
            // btnEndTutorial
            // 
            this.btnEndTutorial.Location = new System.Drawing.Point(803, 557);
            this.btnEndTutorial.Name = "btnEndTutorial";
            this.btnEndTutorial.Size = new System.Drawing.Size(110, 45);
            this.btnEndTutorial.TabIndex = 19;
            this.btnEndTutorial.Text = "Zavrsi tutorijal";
            this.btnEndTutorial.UseVisualStyleBackColor = true;
            this.btnEndTutorial.Click += new System.EventHandler(this.btnEndTutorial_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "../../help/help project.chm";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1184, 695);
            this.Controls.Add(this.btnEndTutorial);
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblUnmappedResources);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlResources);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.lblSelectedResource);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mapa svetskih resursa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelectedResource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resursiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviResursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiketeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlResources;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Label lblUnmappedResources;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordinates;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ToolStripMenuItem tutorijalToolStripMenuItem;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.Button btnEndTutorial;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem1;
        private System.Windows.Forms.HelpProvider helpProvider;

    }
}

