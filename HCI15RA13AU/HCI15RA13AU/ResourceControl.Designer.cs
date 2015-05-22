namespace HCI15RA13AU
{
    partial class ResourceControl
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxIcon
            // 
            this.pbxIcon.Location = new System.Drawing.Point(3, 5);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(50, 50);
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            this.pbxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceControl_MouseDown);
            this.pbxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceControl_MouseMove);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(59, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "label1";
            this.lblID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceControl_MouseDown);
            this.lblID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceControl_MouseMove);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label2";
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceControl_MouseDown);
            this.lblName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceControl_MouseMove);
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(85, 46);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "label1";
            // 
            // ResourceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbxIcon);
            this.Name = "ResourceControl";
            this.Size = new System.Drawing.Size(120, 60);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceControl_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
    }
}
