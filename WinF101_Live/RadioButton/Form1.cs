using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class frmRadioButon : Form
    {
        public frmRadioButon()
        {
            InitializeComponent();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            int sonuc;

            sonuc = int.Parse(lblSonuc.Text);

            if (rbtnArtır.Checked)
            {
                sonuc = (int)(sonuc + nudMiktar.Value);
                lblSonuc.Text=sonuc.ToString();
            }
            else
            {
                sonuc = (int)(sonuc - nudMiktar.Value);
                lblSonuc.Text = sonuc.ToString();
            }
        }
    }
}
