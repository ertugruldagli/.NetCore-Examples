using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO01
{
    public partial class frmADO01_Detail : Form
    {

        public string Mode;

        const string constring = @"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True";


        public frmADO01_Detail()
        {
            InitializeComponent();
        }

        private void frmADO01_Detail_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
             string vs_SQLText = "";

            // bu form her iki işe de yaracağı için hangi modda olduğunu anlatmam lazım

            switch (Mode) {
                case "U":
                    vs_SQLText = "Update Customers SET ";
                    //vs_SQLText += "CompanyName='" + tBoxComName.Text + "'";
                    vs_SQLText += "CompanyName=@CompanyName,";
                    vs_SQLText += "ContactName=@ContactName,";
                    vs_SQLText += "Country=@Country ";
                    vs_SQLText += "WHERE CustomerID=@CustomerID";
                    //sql text oluşturuldu...Parametreli
                    break;
            
            
            }
            using (SqlConnection conn = new SqlConnection(constring))
            {
                using (SqlCommand query = new SqlCommand(vs_SQLText, conn))// conn nesnesini kullanarak sql komutunu oluştur.
                {
                    query.Parameters.AddWithValue("CustomerID", tBoxCustomerID.Text);
                    query.Parameters.AddWithValue("CompanyName", tBoxComName.Text);
                    query.Parameters.AddWithValue("ContactName", tBoxContactName.Text);
                    query.Parameters.AddWithValue("Country", tBoxCountry.Text);

                    query.CommandType= CommandType.Text;

                    try
                    {
                        conn.Open();
                        query.ExecuteNonQuery();

                        MessageBox.Show("Bilgileriniz Güncellenmiştir...");

                        this.Close();
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());

                    }


                   
                }
            }

        }
    }
}
