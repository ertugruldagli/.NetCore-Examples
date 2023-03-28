using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuloSevkiyat
{
    public partial class frmRuloYukleme : Form
    {
        public frmRuloYukleme()
        {
            InitializeComponent();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
           inteCran ic=new inteCran();
            ic.ShowDialog();
        }

        private void btnAdres_Click(object sender, EventArgs e)
        {

        }
    }
}
