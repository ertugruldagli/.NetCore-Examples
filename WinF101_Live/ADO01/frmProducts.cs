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
    public partial class frmProducts : Form
    {

        const string constring = @"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True";

        string vs_SQLCommend="";//sql komutlarını içerecek 
        string vs_SQLQuery = ""; //Query text tutacak
        string Mode = "";

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

        private void BindGrid()
        {
            //dg yi dolduran bölüm
            using (SqlConnection conn = new SqlConnection(constring))
            {
                /*SELECT ProductId, ProductName, Categories.CategoryName, Suppliers.CompanyName, UnitsInStock,Discontinued
                    FROM Products
                    INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
                    INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID*/

                vs_SQLCommend= "SELECT ProductId, ProductName, Categories.CategoryName, Suppliers.CompanyName, UnitsInStock,Discontinued FROM Products ";
                vs_SQLCommend += "INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID ";
                vs_SQLCommend += "INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID ";

                using (SqlCommand query = new SqlCommand(vs_SQLCommend, conn))// conn nesnesini kullanarak sql komutunu oluştur.
                {
                    query.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(query))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);

                            dgrwProducts.DataSource = dset.Tables[0];
                        }
                    }
                }
            }

        }

        private void PrepareGrid()
        {
            //datagrid in otomatik olak db tablosuna bakıp gridin sütunlarını yaratmasını istenmemektedir.

            dgrwProducts.AutoGenerateColumns = true;

            //Eğer gd nin en baş tarafındaki kolunu görmmek istemiyorsak

            dgrwProducts.RowHeadersVisible = false;

            dgrwProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // dg deki kolonları  dg nin gneişliğine göre ayarlama

            dgrwProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrwProducts.ReadOnly = true;

            dgrwProducts.AllowUserToAddRows = false;

            dgrwProducts.AllowUserToDeleteRows = false;

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            PrepareGrid();
            BindGrid();
        }

        private void GetCategory()
        {
            //SQL Tarafındaki  Category Tablosundan Sorgulamada Kullanabilmek için  sadece CategoryID ve CategoryName alanalrını almalıyım..
        }
    }
}
