namespace HCI15RA13AU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picEarth = new System.Windows.Forms.PictureBox();
            this.lblSelectedResource = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).BeginInit();
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
            // picEarth
            // 
            this.picEarth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEarth.BackgroundImage")));
            this.picEarth.InitialImage = null;
            this.picEarth.Location = new System.Drawing.Point(12, 12);
            this.picEarth.Name = "picEarth";
            this.picEarth.Size = new System.Drawing.Size(811, 498);
            this.picEarth.TabIndex = 1;
            this.picEarth.TabStop = false;
            // 
            // lblSelectedResource
            // 
            this.lblSelectedResource.AutoSize = true;
            this.lblSelectedResource.Location = new System.Drawing.Point(71, 533);
            this.lblSelectedResource.Name = "lblSelectedResource";
            this.lblSelectedResource.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedResource.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(881, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Dodaj resurs";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 524);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSelectedResource);
            this.Controls.Add(this.picEarth);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Mapa svetskih resursa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picEarth;
        private System.Windows.Forms.Label lblSelectedResource;
        private System.Windows.Forms.Button btnAdd;

    }
}

