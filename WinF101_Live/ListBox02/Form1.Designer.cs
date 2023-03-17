namespace ListBox02
{
    partial class frmListBox02
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
            this.tBoxAdet = new System.Windows.Forms.TextBox();
            this.tBoxAlt = new System.Windows.Forms.TextBox();
            this.tBoxUst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.liBoxSonuc = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxAdet
            // 
            this.tBoxAdet.Location = new System.Drawing.Point(108, 41);
            this.tBoxAdet.Name = "tBoxAdet";
            this.tBoxAdet.Size = new System.Drawing.Size(35, 20);
            this.tBoxAdet.TabIndex = 0;
            // 
            // tBoxAlt
            // 
            this.tBoxAlt.Location = new System.Drawing.Point(108, 65);
            this.tBoxAlt.Name = "tBoxAlt";
            this.tBoxAlt.Size = new System.Drawing.Size(65, 20);
            this.tBoxAlt.TabIndex = 1;
            // 
            // tBoxUst
            // 
            this.tBoxUst.Location = new System.Drawing.Point(108, 91);
            this.tBoxUst.Name = "tBoxUst";
            this.tBoxUst.Size = new System.Drawing.Size(65, 20);
            this.tBoxUst.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Getirilecek Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alt Sınır: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Üst Sınır:";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(93, 117);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(97, 26);
            this.btnUret.TabIndex = 6;
            this.btnUret.Text = "Uret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // liBoxSonuc
            // 
            this.liBoxSonuc.FormattingEnabled = true;
            this.liBoxSonuc.Location = new System.Drawing.Point(218, 44);
            this.liBoxSonuc.Name = "liBoxSonuc";
            this.liBoxSonuc.Size = new System.Drawing.Size(97, 95);
            this.liBoxSonuc.TabIndex = 7;
            this.liBoxSonuc.SelectedIndexChanged += new System.EventHandler(this.liBoxSonuc_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(303, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmListBox02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 309);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.liBoxSonuc);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxUst);
            this.Controls.Add(this.tBoxAlt);
            this.Controls.Add(this.tBoxAdet);
            this.Name = "frmListBox02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmListBox02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxAdet;
        private System.Windows.Forms.TextBox tBoxAlt;
        private System.Windows.Forms.TextBox tBoxUst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.ListBox liBoxSonuc;
        private System.Windows.Forms.Button btnExit;
    }
}

