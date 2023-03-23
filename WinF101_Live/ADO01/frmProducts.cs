using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO01
{
    public partial class frmProducts : Form
    {

        const string constring = @"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True";
        string vs_SQLCommend="";//sql komutlarını içerecek 
        string vs_SQLQuery = ""; //Query text tutacak

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
