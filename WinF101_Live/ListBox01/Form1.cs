using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox01
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnSayilar_Click(object sender, EventArgs e)
        {
            liBox.Items.Clear();

            int adet = int.Parse(txtAdet.Text);
            for (int i = 1; i <= adet; i++)
            {
                string sayiText = i.ToString();
                liBox.Items.Add(sayiText + ". sayi ");

            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
