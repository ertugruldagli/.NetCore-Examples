namespace ComboBox01
{
    partial class frmCbox01
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBox01Listele = new System.Windows.Forms.ComboBox();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayilar:";
            // 
            // cBox01Listele
            // 
            this.cBox01Listele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox01Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox01Listele.FormattingEnabled = true;
            this.cBox01Listele.Location = new System.Drawing.Point(12, 74);
            this.cBox01Listele.Name = "cBox01Listele";
            this.cBox01Listele.Size = new System.Drawing.Size(198, 33);
            this.cBox01Listele.TabIndex = 1;
            // 
            // btnSayilar
            // 
            this.btnSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayilar.Location = new System.Drawing.Point(44, 127);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(132, 33);
            this.btnSayilar.TabIndex = 2;
            this.btnSayilar.Text = "Liste Oluştur";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(340, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(240, 16);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(110, 20);
            this.txtAdet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet: ";
            // 
            // frmCbox01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.cBox01Listele);
            this.Controls.Add(this.label1);
            this.Name = "frmCbox01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCbox01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox01Listele;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label2;
    }
}

