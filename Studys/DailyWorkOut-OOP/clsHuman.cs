using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWorkOut_OOP
{
    internal class clsHuman
    {
        public string ad;
        public string soyad;
        public string brithDay;
        public string title;


        public clsHuman() {

            Console.WriteLine("İsim Giriniz: ");
            ad = Console.ReadLine();

            Console.WriteLine("İsim Giriniz: ");
            soyad = Console.ReadLine();

            Console.WriteLine("İsim Giriniz: ");
            brithDay = Console.ReadLine();

            Console.WriteLine("İsim Giriniz: ");
            title = Console.ReadLine();


        }


    }
}
