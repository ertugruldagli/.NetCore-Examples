namespace ADO01
{
    partial class frmProducts
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabcProducts = new System.Windows.Forms.TabControl();
            this.tabpData = new System.Windows.Forms.TabPage();
            this.dgrwProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboxQSuppliers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxQProductName = new System.Windows.Forms.TextBox();
            this.tabpDetail = new System.Windows.Forms.TabPage();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tboxCategory = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudStokCty = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabcProducts.SuspendLayout();
            this.tabpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokCty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(757, 502);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabcProducts
            // 
            this.tabcProducts.Controls.Add(this.tabpData);
            this.tabcProducts.Controls.Add(this.tabpDetail);
            this.tabcProducts.Location = new System.Drawing.Point(12, 12);
            this.tabcProducts.Name = "tabcProducts";
            this.tabcProducts.SelectedIndex = 0;
            this.tabcProducts.Size = new System.Drawing.Size(796, 484);
            this.tabcProducts.TabIndex = 1;
            // 
            // tabpData
            // 
            this.tabpData.Controls.Add(this.btnDelete);
            this.tabpData.Controls.Add(this.btnUpdate);
            this.tabpData.Controls.Add(this.btnEkle);
            this.tabpData.Controls.Add(this.dgrwProducts);
            this.tabpData.Controls.Add(this.groupBox1);
            this.tabpData.Location = new System.Drawing.Point(4, 24);
            this.tabpData.Name = "tabpData";
            this.tabpData.Padding = new System.Windows.Forms.Padding(3);
            this.tabpData.Size = new System.Drawing.Size(788, 456);
            this.tabpData.TabIndex = 1;
            this.tabpData.Text = "General";
            this.tabpData.UseVisualStyleBackColor = true;
            // 
            // dgrwProducts
            // 
            this.dgrwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwProducts.Location = new System.Drawing.Point(15, 221);
            this.dgrwProducts.Name = "dgrwProducts";
            this.dgrwProducts.Size = new System.Drawing.Size(754, 187);
            this.dgrwProducts.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.cboxQSuppliers);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxQProductName);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorgu Seçenekleri";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(6, 162);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(83, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "Sorgula";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboxQSuppliers
            // 
            this.cboxQSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQSuppliers.FormattingEnabled = true;
            this.cboxQSuppliers.Location = new System.Drawing.Point(112, 96);
            this.cboxQSuppliers.Name = "cboxQSuppliers";
            this.cboxQSuppliers.Size = new System.Drawing.Size(186, 23);
            this.cboxQSuppliers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier:";
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(112, 67);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(129, 23);
            this.cboxCategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name: ";
            // 
            // tboxQProductName
            // 
            this.tboxQProductName.Location = new System.Drawing.Point(112, 38);
            this.tboxQProductName.Name = "tboxQProductName";
            this.tboxQProductName.Size = new System.Drawing.Size(205, 23);
            this.tboxQProductName.TabIndex = 0;
            // 
            // tabpDetail
            // 
            this.tabpDetail.BackColor = System.Drawing.Color.Teal;
            this.tabpDetail.Controls.Add(this.btnAdd);
            this.tabpDetail.Controls.Add(this.cboxDiscontinued);
            this.tabpDetail.Controls.Add(this.label9);
            this.tabpDetail.Controls.Add(this.nudStokCty);
            this.tabpDetail.Controls.Add(this.label8);
            this.tabpDetail.Controls.Add(this.label7);
            this.tabpDetail.Controls.Add(this.tboxPrice);
            this.tabpDetail.Controls.Add(this.comboBoxSuppliers);
            this.tabpDetail.Controls.Add(this.label6);
            this.tabpDetail.Controls.Add(this.label5);
            this.tabpDetail.Controls.Add(this.label4);
            this.tabpDetail.Controls.Add(this.comboBoxCategory);
            this.tabpDetail.Controls.Add(this.tboxCategory);
            this.tabpDetail.Location = new System.Drawing.Point(4, 24);
            this.tabpDetail.Name = "tabpDetail";
            this.tabpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDetail.Size = new System.Drawing.Size(788, 456);
            this.tabpDetail.TabIndex = 0;
            this.tabpDetail.Text = "Detail";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(16, 414);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(127, 414);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(239, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tboxCategory
            // 
            this.tboxCategory.Location = new System.Drawing.Point(169, 36);
            this.tboxCategory.Name = "tboxCategory";
            this.tboxCategory.Size = new System.Drawing.Size(193, 23);
            this.tboxCategory.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(169, 83);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(99, 23);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Suppliers: ";
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(169, 138);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(99, 23);
            this.comboBoxSuppliers.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Unit Price: ";
            // 
            // tboxPrice
            // 
            this.tboxPrice.Location = new System.Drawing.Point(169, 192);
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.Size = new System.Drawing.Size(151, 23);
            this.tboxPrice.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Unit In Stok: ";
            // 
            // nudStokCty
            // 
            this.nudStokCty.Location = new System.Drawing.Point(169, 246);
            this.nudStokCty.Name = "nudStokCty";
            this.nudStokCty.Size = new System.Drawing.Size(151, 23);
            this.nudStokCty.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Discontinued: ";
            // 
            // cboxDiscontinued
            // 
            this.cboxDiscontinued.AutoSize = true;
            this.cboxDiscontinued.Location = new System.Drawing.Point(169, 302);
            this.cboxDiscontinued.Name = "cboxDiscontinued";
            this.cboxDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.cboxDiscontinued.TabIndex = 12;
            this.cboxDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(201, 340);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(827, 540);
            this.Controls.Add(this.tabcProducts);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.tabcProducts.ResumeLayout(false);
            this.tabpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabpDetail.ResumeLayout(false);
            this.tabpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokCty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabcProducts;
        private System.Windows.Forms.TabPage tabpDetail;
        private System.Windows.Forms.TabPage tabpData;
        private System.Windows.Forms.DataGridView dgrwProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxQProductName;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxQSuppliers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox tboxCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cboxDiscontinued;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudStokCty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxPrice;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}