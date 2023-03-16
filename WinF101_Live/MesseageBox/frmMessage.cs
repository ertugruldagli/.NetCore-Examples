using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesseageBox
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string message;

            message = "Hello World! What's up?";
            tboxMessage.Text = message; // parametre gönderildi!


            // MessageBox.Show("Merhaba Ertugrul");
            //MessageBox.Show(message);  //Burada parametre gönderild!
        }
    }
}
