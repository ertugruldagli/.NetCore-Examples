using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesBox
{
    public partial class frmSec : Form
    {
        public frmSec()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ofdSec.Title = "Lütfen resim dosyasını seçiniz...";

            if (ofdSec.ShowDialog()==DialogResult.OK) //ofd diyaloğu açıldı ve okay tuşuyla geri dönüldü ise
            {
                frmPictureBox frmPictureBox = new frmPictureBox();
                
                foreach(Control c in frmPictureBox.Controls)
                {
                    if(c.Name== "lblFileName")
                        c. Text= ofdSec.FileName;
                }

                frmPictureBox.ShowDialog();
            }
        }
    }
}
