using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal class clsDbManager
    {

        private IDatabase database;

        public clsDbManager() { }

        public clsDbManager(IDatabase database) { 
            
            this.database = database;
        }

        public void loginDB()
        {
            string userName, passWord;

            Console.WriteLine("Veritabanı bağlantısı  \n\n kullanici ad:");
            userName= Console.ReadLine();

            Console.WriteLine("Veritabanı bağlantısı  \n\n kullanici password:");
            passWord = Console.ReadLine();

            if (database.login(userName,passWord)==1)
            {
               
            }
        }
    }
}
