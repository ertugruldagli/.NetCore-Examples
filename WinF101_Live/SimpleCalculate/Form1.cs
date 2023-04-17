using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculate
{
    public partial class frmSimple : Form
    {
        public frmSimple()
        {
            InitializeComponent();
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {

            double sayi1, sayi2, sonuc=0;
            string secenek;

  

            if (tboxSayi1.Text != "" && tboxSayi2.Text != "")
            {
                sayi1 = Convert.ToDouble(tboxSayi1.Text);
                sayi2 = Convert.ToDouble(tboxSayi2.Text);

                secenek = cboxControl.Text;

                switch (secenek)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                        
                        if (sayi2!=0)
                        {
                            sonuc = sayi1 / sayi2;
                        }
                        else
                        {
                            MessageBox.Show("0'a bölme hatası!");
                        }
                        break;
                  
                }
            }
            else
            {
                MessageBox.Show("Lütfen Değerleri boş bırakmayınız!");
            }

     
         
            //toplam = sayi1+sayi2;

            //MessageBox.Show(Convert.ToString(toplam));

            //MessageBox.Show("İşlemin Sonucu: " + toplam.ToString());

            lblSonuc.Text = "İşlemin Sonucu: "+sonuc.ToString();
            lblSonuc.Visible = true;

            tboxSayi1.Clear();
            tboxSayi2.Clear();

            tboxSayi1.Focus();// imleci textboxun üstüne konumlandır.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tboxSayi1_Enter(object sender, EventArgs e)
        {
         
        }
        private void tboxSayi2_Enter(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSimple_Load(object sender, EventArgs e)
        {
            //Form ekrana ilk gelirken yapılacak işlemler

            cboxControl.SelectedIndex = 0;
        }

        private void cboxControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
