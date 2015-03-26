namespace HCI15RA13AU
{
    partial class AddForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesription = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbRenewable = new System.Windows.Forms.CheckBox();
            this.chbImportant = new System.Windows.Forms.CheckBox();
            this.chbExploatable = new System.Windows.Forms.CheckBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.rbtRare = new System.Windows.Forms.RadioButton();
            this.rbtFrequent = new System.Windows.Forms.RadioButton();
            this.rbtUniversal = new System.Windows.Forms.RadioButton();
            this.btnIcon = new System.Windows.Forms.Button();
            this.epAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblIconName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Oznaka";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naziv";
            // 
            // lblDesription
            // 
            this.lblDesription.AutoSize = true;
            this.lblDesription.Location = new System.Drawing.Point(13, 79);
            this.lblDesription.Name = "lblDesription";
            this.lblDesription.Size = new System.Drawing.Size(28, 13);
            this.lblDesription.TabIndex = 2;
            this.lblDesription.Text = "Opis";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(13, 417);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(72, 13);
            this.lblUnit.TabIndex = 3;
            this.lblUnit.Text = "Jedinica mere";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(13, 253);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(62, 13);
            this.lblFrequency.TabIndex = 4;
            this.lblFrequency.Text = "Frekvencija";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 5;
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(136, 76);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 120);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(348, 554);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(466, 554);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chbRenewable
            // 
            this.chbRenewable.AutoSize = true;
            this.chbRenewable.Location = new System.Drawing.Point(16, 304);
            this.chbRenewable.Name = "chbRenewable";
            this.chbRenewable.Size = new System.Drawing.Size(70, 17);
            this.chbRenewable.TabIndex = 15;
            this.chbRenewable.Text = "Obnovljiv";
            this.chbRenewable.UseVisualStyleBackColor = true;
            // 
            // chbImportant
            // 
            this.chbImportant.AutoSize = true;
            this.chbImportant.Location = new System.Drawing.Point(16, 338);
            this.chbImportant.Name = "chbImportant";
            this.chbImportant.Size = new System.Drawing.Size(99, 17);
            this.chbImportant.TabIndex = 16;
            this.chbImportant.Text = "Strateški važan";
            this.chbImportant.UseVisualStyleBackColor = true;
            // 
            // chbExploatable
            // 
            this.chbExploatable.AutoSize = true;
            this.chbExploatable.Location = new System.Drawing.Point(16, 375);
            this.chbExploatable.Name = "chbExploatable";
            this.chbExploatable.Size = new System.Drawing.Size(141, 17);
            this.chbExploatable.TabIndex = 17;
            this.chbExploatable.Text = "Moguća je ekspolatacija";
            this.chbExploatable.UseVisualStyleBackColor = true;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(13, 219);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(42, 13);
            this.lblIcon.TabIndex = 18;
            this.lblIcon.Text = "Ikonica";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(13, 455);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(89, 13);
            this.lblCost.TabIndex = 19;
            this.lblCost.Text = "Cena (u dolarima)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 489);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 13);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Datum otkrivanja";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(136, 452);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(75, 20);
            this.txtCost.TabIndex = 21;
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            // 
            // rbtRare
            // 
            this.rbtRare.AutoSize = true;
            this.rbtRare.Location = new System.Drawing.Point(136, 253);
            this.rbtRare.Name = "rbtRare";
            this.rbtRare.Size = new System.Drawing.Size(57, 17);
            this.rbtRare.TabIndex = 23;
            this.rbtRare.TabStop = true;
            this.rbtRare.Text = "Redak";
            this.rbtRare.UseVisualStyleBackColor = true;
            this.rbtRare.Validating += new System.ComponentModel.CancelEventHandler(this.rbtRare_Validating);
            // 
            // rbtFrequent
            // 
            this.rbtFrequent.AutoSize = true;
            this.rbtFrequent.Location = new System.Drawing.Point(241, 253);
            this.rbtFrequent.Name = "rbtFrequent";
            this.rbtFrequent.Size = new System.Drawing.Size(46, 17);
            this.rbtFrequent.TabIndex = 24;
            this.rbtFrequent.TabStop = true;
            this.rbtFrequent.Text = "Čest";
            this.rbtFrequent.UseVisualStyleBackColor = true;
            this.rbtFrequent.Validating += new System.ComponentModel.CancelEventHandler(this.rbtFrequent_Validating);
            // 
            // rbtUniversal
            // 
            this.rbtUniversal.AutoSize = true;
            this.rbtUniversal.Location = new System.Drawing.Point(342, 253);
            this.rbtUniversal.Name = "rbtUniversal";
            this.rbtUniversal.Size = new System.Drawing.Size(81, 17);
            this.rbtUniversal.TabIndex = 25;
            this.rbtUniversal.TabStop = true;
            this.rbtUniversal.Text = "Univerzalan";
            this.rbtUniversal.UseVisualStyleBackColor = true;
            this.rbtUniversal.Validating += new System.ComponentModel.CancelEventHandler(this.rbtUniversal_Validating);
            // 
            // btnIcon
            // 
            this.btnIcon.Location = new System.Drawing.Point(136, 214);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(75, 23);
            this.btnIcon.TabIndex = 26;
            this.btnIcon.Text = "Učitaj";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // epAdd
            // 
            this.epAdd.ContainerControl = this;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(136, 489);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 27;
            this.dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_Validating);
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "merica",
            "barel",
            "tona",
            "kilogram"});
            this.cmbUnit.Location = new System.Drawing.Point(136, 414);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbUnit.TabIndex = 28;
            this.cmbUnit.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUnit_Validating);
            // 
            // lblIconName
            // 
            this.lblIconName.AutoSize = true;
            this.lblIconName.Location = new System.Drawing.Point(220, 219);
            this.lblIconName.Name = "lblIconName";
            this.lblIconName.Size = new System.Drawing.Size(104, 13);
            this.lblIconName.TabIndex = 30;
            this.lblIconName.Text = "Ikonica nije izabrana";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 606);
            this.Controls.Add(this.lblIconName);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.rbtUniversal);
            this.Controls.Add(this.rbtFrequent);
            this.Controls.Add(this.rbtRare);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.chbExploatable);
            this.Controls.Add(this.chbImportant);
            this.Controls.Add(this.chbRenewable);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblDesription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "AddForm";
            this.Text = "Dodaj resurs";
            ((System.ComponentModel.ISupportInitialize)(this.epAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesription;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbRenewable;
        private System.Windows.Forms.CheckBox chbImportant;
        private System.Windows.Forms.CheckBox chbExploatable;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.RadioButton rbtRare;
        private System.Windows.Forms.RadioButton rbtFrequent;
        private System.Windows.Forms.RadioButton rbtUniversal;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.ErrorProvider epAdd;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblIconName;
    }
}