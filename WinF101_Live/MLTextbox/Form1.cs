using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLTextbox
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int rsTam;
        double rsOndalik;
        double gercekSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
      
            IslemYap();
            MesajVer("merhaba");
            SayiUret();
        }

        public void IslemYap()
        {

                tBoxML.Text += (SayiUret().ToString()) + "\n\n\n";
            
        }

        public void MesajVer(string prmMessage)
        {
            lblMessage.Visible = true;
            // lblMessage.Text = "this is my World!";
            lblMessage.Text += prmMessage;
           
        }

        public double SayiUret()
        {
           rsTam=rnd.Next(1,10);
           rsOndalik = rnd.NextDouble(); //nextDouble methodu sadece 0 ile 1 arasında değer üretir.

           return gercekSayi=rsTam+rsOndalik;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}
