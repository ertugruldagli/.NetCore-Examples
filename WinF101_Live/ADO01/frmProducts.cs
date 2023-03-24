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
        string vs_SQLCommendAna = "";
        string Mode = "";

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindGrid(string prmSQLText)
        {
            //dg yi dolduran bölüm
            using (SqlConnection conn = new SqlConnection(constring))
            {
             

                //vs_SQLCommend= "SELECT ProductId, ProductName, Categories.CategoryName, Suppliers.CompanyName, UnitsInStock,Discontinued FROM Products ";
                //vs_SQLCommend += "INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID ";
                //vs_SQLCommend += "INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID ";
                //vs_SQLCommend += "WHERE ProductID > 0 ";

                using (SqlCommand query = new SqlCommand(prmSQLText, conn))// conn nesnesini kullanarak sql komutunu oluştur.
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
            vs_SQLCommendAna = "SELECT ProductId, ProductName, Products.CategoryID, Categories.CategoryName, Suppliers.CompanyName, UnitsInStock,Discontinued FROM Products ";
            vs_SQLCommendAna += "INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID ";
            vs_SQLCommendAna += "INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID ";
            vs_SQLCommendAna += "WHERE ProductID > 0 ";
            BindGrid(vs_SQLCommendAna);
            GetCategory();
        }

        private void GetCategory()
        {
            //SQL Tarafındaki  Category Tablosundan Sorgulamada Kullanabilmek için  sadece CategoryID ve CategoryName alanalrını almalıyım..
            //dg yi dolduran bölüm
            using (SqlConnection conn = new SqlConnection(constring))
            {
                /*SELECT ProductId, ProductName, Categories.CategoryName, Suppliers.CompanyName, UnitsInStock,Discontinued
                    FROM Products
                    INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
                    INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID*/

                vs_SQLCommend = "SELECT CategoryID, CategoryName FROM Categories ";
             

                using (SqlCommand query = new SqlCommand(vs_SQLCommend, conn))// conn nesnesini kullanarak sql komutunu oluştur.
                {
                    query.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(query))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);

                            //comboboxın ilk satırı -- hepsi yazzsın
                            //data tabloların olmayan bir satırı oluşturmak için kullanılan bir class var ilk olrak bunun gözükmesini sağlayacak.

                            DataRow newRow = dset.Tables[0].NewRow() ; // Yeni bir satır açıyoruz.

                            newRow["CategoryID"] = 0;
                            newRow["CategoryName"] = "--- Hepsi ---";
                            dset.Tables[0].Rows.InsertAt(newRow,0);// db tablosunda olmayan kayıdı  combo boxın 0.indeksine koyuyorum ki ilk o gözüksün...

                              cboxCategory.DataSource = dset.Tables[0];

                              cboxCategory.ValueMember= "CategoryID";//comboboxta gösterir
                              cboxCategory.DisplayMember = "CategoryName";

                            //detail menusu içerisinde olan 
                            comboBoxCategory.DataSource = dset.Tables[0];
                            comboBoxCategory.ValueMember = "CategoryID";//comboboxta gösterir
                            comboBoxCategory.DisplayMember = "CategoryName";



                        }
                    }
                }
            }
        }



        private void btnQuery_Click(object sender, EventArgs e)
        {
            vs_SQLQuery = "";

            if (tboxQProductName.Text != "")
            {
                vs_SQLQuery += " AND ProductName LIKE '%" + tboxQProductName.Text + "%' ";
            }


            //Catogry combsundaki değişimi eğer varsa selectedIndex propertsi varsa

            if (cboxCategory.SelectedIndex>0)
            {
                vs_SQLQuery += " AND Products.CategoryID =" + cboxCategory.SelectedIndex;
            }
            BindGrid(vs_SQLCommendAna + vs_SQLQuery);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U");
        }

        private void ShowData(string prmMode)
        {
            //bu method parametrik olacak..
            //üzerine gelen parametreye göre 
            // (I veya U) detay sayfasındaki boş duran yerleri datagridden okuyarak doldurulacaktır.

            switch (prmMode)
            {
                case "U":
                    tboxCategory.Text = dgrwProducts.CurrentRow.Cells[1].Value.ToString();
                    cboxCategory.SelectedValue = dgrwProducts.CurrentRow.Cells[2].Value;

                   // comboBoxSuppliers.SelectedValue = dgrwProducts.CurrentRow.Cells[4];
                    break;


                case "I":
                    break;
            }

            tabcProducts.SelectedTab = tabcProducts.TabPages[1];
            
        }

        private void dgrwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
