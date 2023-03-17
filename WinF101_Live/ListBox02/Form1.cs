﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox02
{
    public partial class frmListBox02 : Form
    {
        Random rnd = new Random();
        public frmListBox02()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void liBoxSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmListBox02_Load(object sender, EventArgs e)
        {
            
          
            tBoxAdet.Text = "";

            tBoxAlt.Clear();
            tBoxUst.Clear();

            liBoxSonuc.Items.Clear();

            tBoxAdet.Focus(); 
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            if (tBoxAdet.Text !="")
            {
                //işleme girsin 
                if (tBoxAlt.Text != "" && tBoxUst.Text != "" )
                {
                    for (int i = 0; i <=  int.Parse(tBoxAdet.Text) ; i++)
                    {
                        int rSayi=rnd.Next(int.Parse(tBoxAlt.Text), int.Parse(tBoxUst.Text));

                        liBoxSonuc.Items.Add(rSayi.ToString());
                    }
                }
            }
        }
    }
}
