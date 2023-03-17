using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox01
{
    public partial class frmCbox01 : Form
    {
        public frmCbox01()
        {
            InitializeComponent();
        }

        private void btnSayilar_Click(object sender, EventArgs e)
        {
            cBox01Listele.Items.Clear();  //combox içini temizler.. tekrarlama işlemi yapmaz!

            //for (int i = 1;i<=20;i++)
            //{
            //    //cBox01Listele.Items.Add($"{i}. Sayi"); kısayolu

            //    string sayiText=i.ToString();
            //    cBox01Listele.Items.Add(sayiText);

            //}

            int adet = int.Parse(txtAdet.Text);
            for (int i = 1; i <= adet; i++)
            {
                string sayiText = i.ToString();
                cBox01Listele.Items.Add(sayiText +". sayi ");

            }
            //cBox01Listele.Enabled = true;
            


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      // exit formu kapatma

        private void frmCbox01_Load(object sender, EventArgs e)        //
        {
            txtAdet.Select();
            //cBox01Listele.Enabled= false;
            
        }
    }
}
