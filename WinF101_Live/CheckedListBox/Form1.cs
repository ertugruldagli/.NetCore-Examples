using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class frmCheckedListBox : Form
    {
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int checkedOptionIndex; //Tıklanılan ve check haline gelen seçeneği seçin

            string checkedContentText; // içeriğindeki text bilgi

            //seçilen indeksin elemanın indeksini öğrenmem lazım
            checkedOptionIndex = e.Index;

            // içindeki yazan texti öğreneyim
            checkedContentText = checkedListBox1.Items[checkedOptionIndex].ToString();

            if (listBox1.Items.IndexOf(checkedContentText) > -1)
                return;//-1 burada araştırılan textin olduğunu gösterir. Bu yüzden hiçbir işlem yapmadan methoddan çık.

            //eğer listboxsında seçili değer yoksa demek ki ekleyeceğim ama 
            //checked listboxsın çalışma prensibine göre acaba seçtiğim satırın checkini işaretledi mi kontrolünü yap

            bool contentChecked = checkedListBox1.GetItemChecked(checkedOptionIndex);
            //yukarıdaki açıklama için bir lojik değişkenle bunu anlatacağım
            // üzerinde durulan satırı seçip/seçilmediği anlaşılacak

            if (contentChecked==false)
            {
                listBox1.Items.Add(checkedContentText);
                
            }
            else
            {
                listBox1.Items.RemoveAt(checkedOptionIndex);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i].ToString());
            }
        }
    }
}
