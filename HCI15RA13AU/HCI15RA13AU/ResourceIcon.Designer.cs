namespace HCI15RA13AU
{
    partial class ResourceIcon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ukloniSaMapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxIcon
            // 
            this.pbxIcon.Location = new System.Drawing.Point(2, 2);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            this.pbxIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseDoubleClick);
            this.pbxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseDown);
            this.pbxIcon.MouseHover += new System.EventHandler(this.pbxIcon_MouseHover);
            this.pbxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseMove);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukloniSaMapeToolStripMenuItem,
            this.urediToolStripMenuItem,
            this.obrišiToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(156, 70);
            // 
            // ukloniSaMapeToolStripMenuItem
            // 
            this.ukloniSaMapeToolStripMenuItem.Name = "ukloniSaMapeToolStripMenuItem";
            this.ukloniSaMapeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ukloniSaMapeToolStripMenuItem.Text = "Ukloni sa mape";
            this.ukloniSaMapeToolStripMenuItem.Click += new System.EventHandler(this.ukloniSaMapeToolStripMenuItem_Click);
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.urediToolStripMenuItem.Text = "Uredi";
            this.urediToolStripMenuItem.Click += new System.EventHandler(this.urediToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // ResourceIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbxIcon);
            this.Name = "ResourceIcon";
            this.Size = new System.Drawing.Size(36, 44);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ukloniSaMapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
    }
}
