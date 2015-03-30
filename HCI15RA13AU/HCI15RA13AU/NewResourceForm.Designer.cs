namespace HCI15RA13AU
{
    partial class NewResourceForm
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
            this.grbFrequency = new System.Windows.Forms.GroupBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.btnTag = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epAdd)).BeginInit();
            this.grbFrequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(15, 10);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Oznaka";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 60);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naziv";
            // 
            // lblDesription
            // 
            this.lblDesription.AutoSize = true;
            this.lblDesription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesription.Location = new System.Drawing.Point(15, 110);
            this.lblDesription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesription.Name = "lblDesription";
            this.lblDesription.Size = new System.Drawing.Size(39, 18);
            this.lblDesription.TabIndex = 2;
            this.lblDesription.Text = "Opis";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(700, 160);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(100, 18);
            this.lblUnit.TabIndex = 3;
            this.lblUnit.Text = "Jedinica mere";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(195, 7);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 24);
            this.txtId.TabIndex = 1;
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 24);
            this.txtName.TabIndex = 2;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(195, 107);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(438, 270);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(889, 524);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 32);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1038, 524);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbRenewable
            // 
            this.chbRenewable.AutoSize = true;
            this.chbRenewable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRenewable.Location = new System.Drawing.Point(700, 10);
            this.chbRenewable.Margin = new System.Windows.Forms.Padding(4);
            this.chbRenewable.Name = "chbRenewable";
            this.chbRenewable.Size = new System.Drawing.Size(87, 22);
            this.chbRenewable.TabIndex = 7;
            this.chbRenewable.Text = "Obnovljiv";
            this.chbRenewable.UseVisualStyleBackColor = true;
            // 
            // chbImportant
            // 
            this.chbImportant.AutoSize = true;
            this.chbImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbImportant.Location = new System.Drawing.Point(700, 60);
            this.chbImportant.Margin = new System.Windows.Forms.Padding(4);
            this.chbImportant.Name = "chbImportant";
            this.chbImportant.Size = new System.Drawing.Size(128, 22);
            this.chbImportant.TabIndex = 8;
            this.chbImportant.Text = "Strateški važan";
            this.chbImportant.UseVisualStyleBackColor = true;
            // 
            // chbExploatable
            // 
            this.chbExploatable.AutoSize = true;
            this.chbExploatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExploatable.Location = new System.Drawing.Point(700, 110);
            this.chbExploatable.Margin = new System.Windows.Forms.Padding(4);
            this.chbExploatable.Name = "chbExploatable";
            this.chbExploatable.Size = new System.Drawing.Size(186, 22);
            this.chbExploatable.TabIndex = 9;
            this.chbExploatable.Text = "Moguća je ekspolatacija";
            this.chbExploatable.UseVisualStyleBackColor = true;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.Location = new System.Drawing.Point(15, 400);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(55, 18);
            this.lblIcon.TabIndex = 18;
            this.lblIcon.Text = "Ikonica";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(700, 210);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(126, 18);
            this.lblCost.TabIndex = 19;
            this.lblCost.Text = "Cena (u dolarima)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(700, 400);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 18);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Datum otkrivanja";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(862, 207);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(111, 24);
            this.txtCost.TabIndex = 11;
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            // 
            // rbtRare
            // 
            this.rbtRare.AutoSize = true;
            this.rbtRare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRare.Location = new System.Drawing.Point(36, 21);
            this.rbtRare.Margin = new System.Windows.Forms.Padding(4);
            this.rbtRare.Name = "rbtRare";
            this.rbtRare.Size = new System.Drawing.Size(67, 20);
            this.rbtRare.TabIndex = 13;
            this.rbtRare.TabStop = true;
            this.rbtRare.Text = "Redak";
            this.rbtRare.UseVisualStyleBackColor = true;
            this.rbtRare.Validating += new System.ComponentModel.CancelEventHandler(this.rbtRare_Validating);
            // 
            // rbtFrequent
            // 
            this.rbtFrequent.AutoSize = true;
            this.rbtFrequent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFrequent.Location = new System.Drawing.Point(162, 21);
            this.rbtFrequent.Margin = new System.Windows.Forms.Padding(4);
            this.rbtFrequent.Name = "rbtFrequent";
            this.rbtFrequent.Size = new System.Drawing.Size(53, 20);
            this.rbtFrequent.TabIndex = 14;
            this.rbtFrequent.TabStop = true;
            this.rbtFrequent.Text = "Čest";
            this.rbtFrequent.UseVisualStyleBackColor = true;
            this.rbtFrequent.Validating += new System.ComponentModel.CancelEventHandler(this.rbtFrequent_Validating);
            // 
            // rbtUniversal
            // 
            this.rbtUniversal.AutoSize = true;
            this.rbtUniversal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtUniversal.Location = new System.Drawing.Point(284, 21);
            this.rbtUniversal.Margin = new System.Windows.Forms.Padding(4);
            this.rbtUniversal.Name = "rbtUniversal";
            this.rbtUniversal.Size = new System.Drawing.Size(97, 20);
            this.rbtUniversal.TabIndex = 15;
            this.rbtUniversal.TabStop = true;
            this.rbtUniversal.Text = "Univerzalan";
            this.rbtUniversal.UseVisualStyleBackColor = true;
            this.rbtUniversal.Validating += new System.ComponentModel.CancelEventHandler(this.rbtUniversal_Validating);
            // 
            // btnIcon
            // 
            this.btnIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIcon.Location = new System.Drawing.Point(195, 393);
            this.btnIcon.Margin = new System.Windows.Forms.Padding(4);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(124, 32);
            this.btnIcon.TabIndex = 4;
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
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(852, 395);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 24);
            this.dateTimePicker.TabIndex = 16;
            this.dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_Validating);
            // 
            // cmbUnit
            // 
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "merica",
            "barel",
            "tona",
            "kilogram"});
            this.cmbUnit.Location = new System.Drawing.Point(862, 157);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(180, 26);
            this.cmbUnit.TabIndex = 10;
            this.cmbUnit.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUnit_Validating);
            // 
            // lblIconName
            // 
            this.lblIconName.AutoSize = true;
            this.lblIconName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconName.Location = new System.Drawing.Point(325, 400);
            this.lblIconName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconName.Name = "lblIconName";
            this.lblIconName.Size = new System.Drawing.Size(141, 18);
            this.lblIconName.TabIndex = 30;
            this.lblIconName.Text = "Ikonica nije izabrana";
            // 
            // grbFrequency
            // 
            this.grbFrequency.Controls.Add(this.rbtRare);
            this.grbFrequency.Controls.Add(this.rbtFrequent);
            this.grbFrequency.Controls.Add(this.rbtUniversal);
            this.grbFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFrequency.Location = new System.Drawing.Point(700, 260);
            this.grbFrequency.Name = "grbFrequency";
            this.grbFrequency.Size = new System.Drawing.Size(450, 52);
            this.grbFrequency.TabIndex = 12;
            this.grbFrequency.TabStop = false;
            this.grbFrequency.Text = "Frekvencija";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(15, 450);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(53, 18);
            this.lblTags.TabIndex = 32;
            this.lblTags.Text = "Etikete";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(325, 450);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(95, 18);
            this.lblTag.TabIndex = 33;
            this.lblTag.Text = "Nema etiketa";
            // 
            // btnTag
            // 
            this.btnTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTag.Location = new System.Drawing.Point(195, 443);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(124, 32);
            this.btnTag.TabIndex = 5;
            this.btnTag.Text = "Dodaj etiketu";
            this.btnTag.UseVisualStyleBackColor = true;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // btnType
            // 
            this.btnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.Location = new System.Drawing.Point(195, 493);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(124, 32);
            this.btnType.TabIndex = 6;
            this.btnType.Text = "Definiši tip";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            this.btnType.Validating += new System.ComponentModel.CancelEventHandler(this.btnType_Validating);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(15, 500);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 18);
            this.lblType.TabIndex = 35;
            this.lblType.Text = "Tip resursa";
            // 
            // NewResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 576);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.grbFrequency);
            this.Controls.Add(this.lblIconName);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnIcon);
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
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblDesription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewResourceForm";
            this.Text = "Dodaj novi resurs";
            ((System.ComponentModel.ISupportInitialize)(this.epAdd)).EndInit();
            this.grbFrequency.ResumeLayout(false);
            this.grbFrequency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesription;
        private System.Windows.Forms.Label lblUnit;
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
        private System.Windows.Forms.GroupBox grbFrequency;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnType;
    }
}