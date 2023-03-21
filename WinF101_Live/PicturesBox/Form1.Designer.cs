namespace PicturesBox
{
    partial class frmPictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pibocPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibocPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pibocPic
            // 
            this.pibocPic.Image = ((System.Drawing.Image)(resources.GetObject("pibocPic.Image")));
            this.pibocPic.Location = new System.Drawing.Point(429, 60);
            this.pibocPic.Name = "pibocPic";
            this.pibocPic.Size = new System.Drawing.Size(314, 377);
            this.pibocPic.TabIndex = 0;
            this.pibocPic.TabStop = false;
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.pibocPic);
            this.Name = "frmPictureBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Box";
            this.Load += new System.EventHandler(this.frmPictureBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPictureBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pibocPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibocPic;
    }
}

