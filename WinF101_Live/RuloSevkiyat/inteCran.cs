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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RuloSevkiyat
{
    public partial class inteCran : Form
    {
        // sql bağlantı değişkeni

        SqlConnection connection = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=iCrane;Integrated Security=True");

        public inteCran()
        {
            InitializeComponent();
        }


        #region ShowData
        private void ShowData(string SelectTable)
        {
            string table = SelectTable;

            switch (table)
            {
                case "t01":

                    string SQLQuery01 = "SELECT * FROM datCoil";

                    using (SqlCommand query = new SqlCommand(SQLQuery01, connection))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(query))
                        {
                            using (DataSet dset = new DataSet())
                            {
                                sda.Fill(dset);
                                dgrwRuloYukleme.DataSource = dset.Tables[0];
                            }
                        }
                    }
                    break;

                case "t02":

                    string SQLQuery02 = "SELECT * FROM datCell";

                    using (SqlCommand query = new SqlCommand(SQLQuery02, connection))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(query))
                        {
                            using (DataSet dset = new DataSet())
                            {
                                sda.Fill(dset);
                                dgrwRuloSevketme.DataSource = dset.Tables[0];
                            }
                        }
                    }
                    break;
                case "t03":

                    string SQLQuery03 = "SELECT * FROM jnkCoCe";

                    using (SqlCommand query = new SqlCommand(SQLQuery03, connection))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(query))
                        {
                            using (DataSet dset = new DataSet())
                            {
                                sda.Fill(dset);
                                dgrwBekleyenIs.DataSource = dset.Tables[0];
                            }
                        }
                    }
                    break;
            }
        }
        #endregion


        #region PropertyGrid
        private void PropertyGrid()
        {
            dgrwRuloYukleme.RowHeadersVisible = false;
            dgrwRuloYukleme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrwRuloSevketme.RowHeadersVisible = false;
            dgrwRuloSevketme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrwBekleyenIs.RowHeadersVisible = false;
            dgrwBekleyenIs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        #endregion


        #region Form Load
        private void inteCran_Load(object sender, EventArgs e)
        {
            PropertyGrid();

            ShowData("t01");
            ShowData("t02");
            ShowData("t03");
        }



        #endregion

        private void btnRuloYukle_Click(object sender, EventArgs e)
        {
            GetRuloYukleme();
        }

        private void dgrwRuloYukleme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRuloYukleme();
        }

        private void GetRuloYukleme()
        {
            frmRuloYukleme ruloYukleme = new frmRuloYukleme();

            ruloYukleme.tboxCoilID.Text = dgrwRuloYukleme.CurrentRow.Cells[0].Value.ToString();
            ruloYukleme.tboxCoilW.Text = dgrwRuloYukleme.CurrentRow.Cells[3].Value.ToString();
            ruloYukleme.tboxCoilD.Text = dgrwRuloYukleme.CurrentRow.Cells[2].Value.ToString();



            ruloYukleme.ShowDialog();
        }

        private void UygunYerBul()
        {
            frmRuloYukleme frm = new frmRuloYukleme();

            int coilW=int.Parse(frm.tboxCoilW.Text);
            int coilD = int.Parse(frm.tboxCoilD.Text);


;        }
    }
}
