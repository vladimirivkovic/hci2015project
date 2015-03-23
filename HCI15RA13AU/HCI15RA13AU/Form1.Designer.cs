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
            this.btnGas = new System.Windows.Forms.Button();
            this.btnOil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedResource = new System.Windows.Forms.Label();
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
            this.picEarth.Click += new System.EventHandler(this.picEarth_Click);
            // 
            // btnGas
            // 
            this.btnGas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGas.BackgroundImage")));
            this.btnGas.Location = new System.Drawing.Point(941, 158);
            this.btnGas.Name = "btnGas";
            this.btnGas.Size = new System.Drawing.Size(128, 128);
            this.btnGas.TabIndex = 5;
            this.btnGas.UseVisualStyleBackColor = true;
            this.btnGas.Click += new System.EventHandler(this.btnGas_Click);
            // 
            // btnOil
            // 
            this.btnOil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOil.BackgroundImage")));
            this.btnOil.Location = new System.Drawing.Point(941, 12);
            this.btnOil.Name = "btnOil";
            this.btnOil.Size = new System.Drawing.Size(128, 128);
            this.btnOil.TabIndex = 6;
            this.btnOil.UseVisualStyleBackColor = true;
            this.btnOil.Click += new System.EventHandler(this.btnOil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selected:";
            // 
            // lblSelectedResource
            // 
            this.lblSelectedResource.AutoSize = true;
            this.lblSelectedResource.Location = new System.Drawing.Point(71, 533);
            this.lblSelectedResource.Name = "lblSelectedResource";
            this.lblSelectedResource.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedResource.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 613);
            this.Controls.Add(this.lblSelectedResource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOil);
            this.Controls.Add(this.btnGas);
            this.Controls.Add(this.picEarth);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picEarth;
        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.Button btnOil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedResource;

    }
}

