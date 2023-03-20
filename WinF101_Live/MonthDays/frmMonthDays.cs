using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthDays
{
    public partial class frmMonthDays : Form
    {

        DateTimeFormatInfo formatTR = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat;// Yani bu değişkene türkçe tarih formatı atandı..

        public frmMonthDays()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMonthDays_Load(object sender, EventArgs e)
        {
            //Form ekranına gelirken 
            // 1. nudYil kontrolünün içindeki gösterilecek bilgiyi günümüzün yılı olarak göstersin
            //2. cboxAy isimli comboboxın otomatik olarak ay adlarıyla doldurulsun ... ay adlarıyla değiştirilsin

            int yil = Convert.ToInt32(DateTime.Now.Year); // default tarihin yıl bilgisini getirir.(şimdiki yılı baz alır.) 

            nudYil.Value= yil;

            for (int i =0; i <12; i++)
            {
                cBoxAy.Items.Add(formatTR.MonthNames[i]); 
            }


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            liBoxAylar.Items.Clear();

            int yil= Convert.ToInt32(nudYil.Value);

            int ay = cBoxAy.SelectedIndex + 1;

            //nud dan ve cboxtan seçilen opsiyonlara göre benim bir tarih  bilgisi olarak programa söylemem lazım

            DateTime tarih = new DateTime(yil,ay,1);

            //seçilen ayda kaç gün var onu öğrenmem lazım

            int totalDaysCount = DateTime.DaysInMonth(yil,ay);

            for (int i = 1; i < totalDaysCount; i++)
            {
                liBoxAylar.Items.Add(tarih.Day + " " + cBoxAy.Text + " " + formatTR.DayNames[(int)tarih.DayOfWeek]);

                tarih=tarih.AddDays(i);
            }
        }
    }
}
