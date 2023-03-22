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
    public partial class frmPictureBox : Form
    {
        int fg, fy, pbg, pby;
       
        public frmPictureBox()

        {
            InitializeComponent();
        }

        private void frmPictureBox_KeyDown(object sender, KeyEventArgs e)
        {
            int x, y;

            x = pibocPic.Location.X;
            y = pibocPic.Location.Y;



            
            //klavyeden hangi tuşa basıldığını keyEventArgstan gelen parametresine göre anlaşılıyor
            switch (e.KeyCode)
            {
               case Keys.Left:
                    x = x - 10;
                    if (x<10)
                    {
                        x=x+10;
                    }
                    break;

               case Keys.Right:

                    x= x + 10;

                    if (pbg+x>fg)
                    {
                        x = x - 10;
                    }
                    break; 

               case Keys.Up:
                    y = y - 10;

                    if (y < 10)
                    {
                        y = y + 10;
                    }
                    break;

               case Keys.Down:
                    y= y + 10;
                    if (pby + y > fy)
                    {
                        y = y - 10;
                    }
                    break;

            }
            pibocPic.Location = new Point(x, y);
            //MessageBox.Show("Koordinatlar : x-> " + x.ToString() + " y-> " + y.ToString());
        }

        private void frmPictureBox_Load(object sender, EventArgs e)
        {
            pibocPic.Location = new Point(0,0);
            

            frmPictureBox frmPictureBox=new frmPictureBox();
            //frmPictureBox.Location = new Point(1,1);

            fg = frmPictureBox.Width-10;
            fy = frmPictureBox.Height;

            pbg = pibocPic.Width;
            pby = pibocPic.Height;

            //MessageBox.Show("Form Genişlik: " + fg + " Form Yükseklik: "+ fy);


            pibocPic.ImageLocation = lblFileName.Text;
            lblFileName.Visible = false;
        }
    }
}
