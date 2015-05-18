namespace HCI15RA13AU
{
    partial class ChooseDate
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
            this.components = new System.ComponentModel.Container();
            this.rbtYear = new System.Windows.Forms.RadioButton();
            this.rbtCentury = new System.Windows.Forms.RadioButton();
            this.rbtUnknown = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCentury = new System.Windows.Forms.TextBox();
            this.chbYear = new System.Windows.Forms.CheckBox();
            this.chbCentury = new System.Windows.Forms.CheckBox();
            this.epDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epDate)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtYear
            // 
            this.rbtYear.AutoSize = true;
            this.rbtYear.Location = new System.Drawing.Point(74, 70);
            this.rbtYear.Name = "rbtYear";
            this.rbtYear.Size = new System.Drawing.Size(74, 22);
            this.rbtYear.TabIndex = 0;
            this.rbtYear.TabStop = true;
            this.rbtYear.Text = "Godina";
            this.rbtYear.UseVisualStyleBackColor = true;
            // 
            // rbtCentury
            // 
            this.rbtCentury.AutoSize = true;
            this.rbtCentury.Location = new System.Drawing.Point(74, 170);
            this.rbtCentury.Name = "rbtCentury";
            this.rbtCentury.Size = new System.Drawing.Size(51, 22);
            this.rbtCentury.TabIndex = 1;
            this.rbtCentury.TabStop = true;
            this.rbtCentury.Text = "Vek";
            this.rbtCentury.UseVisualStyleBackColor = true;
            // 
            // rbtUnknown
            // 
            this.rbtUnknown.AutoSize = true;
            this.rbtUnknown.Location = new System.Drawing.Point(74, 270);
            this.rbtUnknown.Name = "rbtUnknown";
            this.rbtUnknown.Size = new System.Drawing.Size(99, 22);
            this.rbtUnknown.TabIndex = 2;
            this.rbtUnknown.TabStop = true;
            this.rbtUnknown.Text = "Nepoznato";
            this.rbtUnknown.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(317, 317);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 32);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(435, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(193, 67);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 24);
            this.txtYear.TabIndex = 5;
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
            // 
            // txtCentury
            // 
            this.txtCentury.Location = new System.Drawing.Point(193, 167);
            this.txtCentury.Name = "txtCentury";
            this.txtCentury.Size = new System.Drawing.Size(100, 24);
            this.txtCentury.TabIndex = 6;
            this.txtCentury.Validating += new System.ComponentModel.CancelEventHandler(this.txtCentury_Validating);
            // 
            // chbYear
            // 
            this.chbYear.AutoSize = true;
            this.chbYear.Location = new System.Drawing.Point(310, 71);
            this.chbYear.Name = "chbYear";
            this.chbYear.Size = new System.Drawing.Size(63, 22);
            this.chbYear.TabIndex = 7;
            this.chbYear.Text = "p.n.e.";
            this.chbYear.UseVisualStyleBackColor = true;
            // 
            // chbCentury
            // 
            this.chbCentury.AutoSize = true;
            this.chbCentury.Location = new System.Drawing.Point(310, 171);
            this.chbCentury.Name = "chbCentury";
            this.chbCentury.Size = new System.Drawing.Size(63, 22);
            this.chbCentury.TabIndex = 8;
            this.chbCentury.Text = "p.n.e.";
            this.chbCentury.UseVisualStyleBackColor = true;
            // 
            // epDate
            // 
            this.epDate.ContainerControl = this;
            // 
            // ChooseDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(559, 361);
            this.Controls.Add(this.chbCentury);
            this.Controls.Add(this.chbYear);
            this.Controls.Add(this.txtCentury);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbtUnknown);
            this.Controls.Add(this.rbtCentury);
            this.Controls.Add(this.rbtYear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChooseDate";
            this.Text = "Izbor okvirnog datum otkrivanja resursa";
            ((System.ComponentModel.ISupportInitialize)(this.epDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtYear;
        private System.Windows.Forms.RadioButton rbtCentury;
        private System.Windows.Forms.RadioButton rbtUnknown;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCentury;
        private System.Windows.Forms.CheckBox chbYear;
        private System.Windows.Forms.CheckBox chbCentury;
        private System.Windows.Forms.ErrorProvider epDate;
    }
}