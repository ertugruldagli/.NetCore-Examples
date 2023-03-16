namespace SimpleCalculate
{
    partial class frmSimple
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
            this.btnToplam = new System.Windows.Forms.Button();
            this.tboxSayi1 = new System.Windows.Forms.TextBox();
            this.tboxSayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(101, 129);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(109, 25);
            this.btnToplam.TabIndex = 0;
            this.btnToplam.Text = "Hesapla";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // tboxSayi1
            // 
            this.tboxSayi1.Location = new System.Drawing.Point(127, 64);
            this.tboxSayi1.Name = "tboxSayi1";
            this.tboxSayi1.Size = new System.Drawing.Size(60, 20);
            this.tboxSayi1.TabIndex = 1;
            this.tboxSayi1.Enter += new System.EventHandler(this.tboxSayi1_Enter);
            // 
            // tboxSayi2
            // 
            this.tboxSayi2.Location = new System.Drawing.Point(127, 90);
            this.tboxSayi2.Name = "tboxSayi2";
            this.tboxSayi2.Size = new System.Drawing.Size(60, 20);
            this.tboxSayi2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayi 1 Griniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sayi 2 Griniz:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(276, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(124, 174);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Sonuc";
            this.lblSonuc.Visible = false;
            // 
            // frmSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 241);
            this.ControlBox = false;
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxSayi2);
            this.Controls.Add(this.tboxSayi1);
            this.Controls.Add(this.btnToplam);
            this.Name = "frmSimple";
            this.Text = "SimpleCalculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.TextBox tboxSayi1;
        private System.Windows.Forms.TextBox tboxSayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSonuc;
    }
}

