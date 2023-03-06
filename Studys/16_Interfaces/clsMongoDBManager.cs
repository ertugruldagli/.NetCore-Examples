using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal class clsMongoDBManager : IDatabase

    {
        private string value;
        private string userName = "mongo";
        private string passWord = "admin";
        public void addVaule(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.WriteLine("Mongo DB bağlantısı başarılı bir şekilde sonlandırıldı.");
        }

        public void deletevalue(string value)
        {
            this.value = null;

            Console.WriteLine("Veri tabanı üzerindeki bilgiler silindi!");
        }

        public void getValue()
        {
            if (value != null)
            {
                Console.WriteLine($"-> istediğiniz doğrultu da [{value}] verisi başarılı bir şekilde getirildi...\n");
            }
            else
            {
                Console.WriteLine("->veritabanı içinde herhangi bir değer yoktur!  tekrar deneyiniz.... \n");
            }
        }

        public int login(string userName, string passWord)
        {
            if (userName == this.userName && passWord == this.passWord)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void updatevalue(string value)
        {
            this.value = value;

            Console.WriteLine("Bilgiler güncellendi!");
        }
    }
}
}
