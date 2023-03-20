using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicked
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            DateTime startDate=Convert.ToDateTime(dtpStart.Text);

            DateTime endDate = Convert.ToDateTime(dtpFinish.Text);

            TimeSpan sonuc=endDate.Subtract(startDate); // iki tarih arsındaki farkı alıyor

            string year = Convert.ToString(Math.Round(sonuc.TotalDays/365,4)) + " Yıl veya";
            string Month = Convert.ToString(Math.Round(sonuc.TotalDays / 30, 2)) + " Ay veya";
            string day = Convert.ToString(Math.Round(sonuc.TotalDays, 2)) + " Gun veya";
            string hour = Convert.ToString(Math.Round(sonuc.TotalHours, 2)) + " Saat veya";
            string Minute = Convert.ToString(Math.Round(sonuc.TotalMinutes, 2)) +  " Dakika ";

            liBoxResult.Items.Clear();
            liBoxResult.Items.Add("--------------------------");
            liBoxResult.Items.Add(year);
            liBoxResult.Items.Add(Month);
            liBoxResult.Items.Add(day);
            liBoxResult.Items.Add(hour);
            liBoxResult.Items.Add(Minute);
            
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
