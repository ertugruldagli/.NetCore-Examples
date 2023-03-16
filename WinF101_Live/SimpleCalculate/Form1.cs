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
            int sayi1, sayi2, toplam = 0;
               

            sayi1 = int.Parse(tboxSayi1.Text);
            sayi2= int.Parse(tboxSayi2.Text);

            toplam = sayi1+sayi2;

            //MessageBox.Show(Convert.ToString(toplam));

            MessageBox.Show("İşlemin Sonucu: " + toplam.ToString());

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
            MessageBox.Show("şu an bu componenteyim");
        }
    }
}
