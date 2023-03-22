﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO01
{
    public partial class frmADO01 : Form
    {

        const string constring = @"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True";

        public frmADO01()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmADO01_Load(object sender, EventArgs e)
        {
            //Form ilk ekrana geldiğinde dgrid otomatik dolu gelsin
           PrepareGrid(); //dg hazırlanıyor...

            BindGrid(); // dg yi doldur ve ekrana gelsin
        }

        
        private void PrepareGrid()
        {
            //datagrid in otomatik olak db tablosuna bakıp gridin sütunlarını yaratmasını istenmemektedir.

            dgwCustomers.AutoGenerateColumns= true;

            //Eğer gd nin en baş tarafındaki kolunu görmmek istemiyorsak

            dgwCustomers.RowHeadersVisible= false;

            dgwCustomers.SelectionMode= DataGridViewSelectionMode.FullRowSelect;

            // dg deki kolonları  dg nin gneişliğine göre ayarlama

            dgwCustomers.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;

            dgwCustomers.ReadOnly=true;

            dgwCustomers.AllowUserToAddRows= false;

            dgwCustomers.AllowUserToDeleteRows = false;

        }

        private void BindGrid()
        {
            //dg yi dolduran bölüm
            using (SqlConnection conn = new SqlConnection(constring))
            {
                using (SqlCommand query=new SqlCommand("SELECT * FROM Customers",conn))// conn nesnesini kullanarak sql komutunu oluştur.
                {
                   query.CommandType= CommandType.Text;

                    using (SqlDataAdapter sda =new  SqlDataAdapter(query))
                    {
                        using (DataSet dset=new DataSet())
                        {
                            sda.Fill(dset);

                            dgwCustomers.DataSource= dset.Tables[0];
                        }
                    }
                }
            }

        }
        
        private void ShowData(string prmMode)
        {
            frmADO01_Detail detail = new frmADO01_Detail();
            detail.Mode= prmMode;

            //gelen parametreye göre diğer formun elemanalrını ayarlıyoruz.


            switch (prmMode)
            {
                case "I":
                    //Initial değerler veriliyor.
                    detail.tBoxCustomerID.Enabled=true;
                    detail.tBoxComName.Text = " ";
                    detail.tBoxContactName.Text = " ";
                    detail.tBoxCountry.Text = " ";

                    detail.tBoxCustomerID.Select();
                    break;

                case "U":
                    // Initial değerler veriliyor...
                    detail.tBoxCustomerID.Enabled = false;

                    detail.tBoxCustomerID.Text = dgwCustomers.CurrentRow.Cells[0].Value.ToString();
                    detail.tBoxComName.Text = dgwCustomers.CurrentRow.Cells[1].Value.ToString();
                    detail.tBoxContactName.Text = dgwCustomers.CurrentRow.Cells[2].Value.ToString(); ;
                    detail.tBoxCountry.Text = dgwCustomers.CurrentRow.Cells[3].Value.ToString(); ;

                    detail.tBoxComName.Select();
                    break;


            }

            detail.ShowDialog();


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //show data
            ShowData("I");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U");
        }

        private void dgwCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowData("U");
        }
    }
}
