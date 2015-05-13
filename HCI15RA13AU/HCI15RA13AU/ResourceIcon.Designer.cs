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
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxIcon
            // 
            this.pbxIcon.Location = new System.Drawing.Point(2, 2);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            this.pbxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseDown);
            this.pbxIcon.MouseHover += new System.EventHandler(this.pbxIcon_MouseHover);
            this.pbxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseMove);
            // 
            // ResourceIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.pbxIcon);
            this.Name = "ResourceIcon";
            this.Size = new System.Drawing.Size(36, 36);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceIcon_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxIcon;
    }
}
