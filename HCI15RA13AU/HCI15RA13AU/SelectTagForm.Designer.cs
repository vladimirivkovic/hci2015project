namespace HCI15RA13AU
{
    partial class SelectTagForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lstAllTags = new System.Windows.Forms.ListBox();
            this.lstSelectedTags = new System.Windows.Forms.ListBox();
            this.brnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(606, 431);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(471, 431);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 32);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lstAllTags
            // 
            this.lstAllTags.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstAllTags.FormattingEnabled = true;
            this.lstAllTags.ItemHeight = 18;
            this.lstAllTags.Location = new System.Drawing.Point(13, 43);
            this.lstAllTags.Margin = new System.Windows.Forms.Padding(4);
            this.lstAllTags.Name = "lstAllTags";
            this.lstAllTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAllTags.Size = new System.Drawing.Size(244, 292);
            this.lstAllTags.TabIndex = 2;
            this.lstAllTags.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstAllTags_DrawItem);
            // 
            // lstSelectedTags
            // 
            this.lstSelectedTags.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstSelectedTags.FormattingEnabled = true;
            this.lstSelectedTags.ItemHeight = 18;
            this.lstSelectedTags.Location = new System.Drawing.Point(399, 43);
            this.lstSelectedTags.Margin = new System.Windows.Forms.Padding(4);
            this.lstSelectedTags.Name = "lstSelectedTags";
            this.lstSelectedTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSelectedTags.Size = new System.Drawing.Size(240, 292);
            this.lstSelectedTags.TabIndex = 3;
            this.lstSelectedTags.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstSelectedTags_DrawItem);
            // 
            // brnAdd
            // 
            this.brnAdd.Location = new System.Drawing.Point(305, 43);
            this.brnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.brnAdd.Name = "brnAdd";
            this.brnAdd.Size = new System.Drawing.Size(45, 32);
            this.brnAdd.TabIndex = 4;
            this.brnAdd.Text = ">";
            this.brnAdd.UseVisualStyleBackColor = true;
            this.brnAdd.Click += new System.EventHandler(this.brnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(305, 83);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(45, 32);
            this.btnAddAll.TabIndex = 5;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(305, 123);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 32);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(305, 163);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(45, 32);
            this.btnRemoveAll.TabIndex = 7;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(13, 12);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(154, 24);
            this.txtTag.TabIndex = 8;
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            // 
            // SelectTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 479);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.brnAdd);
            this.Controls.Add(this.lstSelectedTags);
            this.Controls.Add(this.lstAllTags);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectTagForm";
            this.Text = "Izbor etiketa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox lstAllTags;
        private System.Windows.Forms.ListBox lstSelectedTags;
        private System.Windows.Forms.Button brnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TextBox txtTag;
    }
}