namespace MonthDays
{
    partial class frmMonthDays
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudYil = new System.Windows.Forms.NumericUpDown();
            this.cBoxAy = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.liBoxAylar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(258, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yıl: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay: ";
            // 
            // nudYil
            // 
            this.nudYil.Location = new System.Drawing.Point(66, 65);
            this.nudYil.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nudYil.Name = "nudYil";
            this.nudYil.Size = new System.Drawing.Size(105, 20);
            this.nudYil.TabIndex = 3;
            // 
            // cBoxAy
            // 
            this.cBoxAy.FormattingEnabled = true;
            this.cBoxAy.Location = new System.Drawing.Point(66, 95);
            this.cBoxAy.Name = "cBoxAy";
            this.cBoxAy.Size = new System.Drawing.Size(105, 21);
            this.cBoxAy.TabIndex = 4;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(78, 122);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(77, 25);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // liBoxAylar
            // 
            this.liBoxAylar.FormattingEnabled = true;
            this.liBoxAylar.Location = new System.Drawing.Point(202, 33);
            this.liBoxAylar.Name = "liBoxAylar";
            this.liBoxAylar.Size = new System.Drawing.Size(121, 134);
            this.liBoxAylar.TabIndex = 6;
            // 
            // frmMonthDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 254);
            this.Controls.Add(this.liBoxAylar);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cBoxAy);
            this.Controls.Add(this.nudYil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMonthDays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthDays";
            this.Load += new System.EventHandler(this.frmMonthDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudYil;
        private System.Windows.Forms.ComboBox cBoxAy;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox liBoxAylar;
    }
}

