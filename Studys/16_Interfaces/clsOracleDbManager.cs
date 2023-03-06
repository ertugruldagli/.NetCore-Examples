using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal class clsOracleDbManager : IDatabase
    {

        private string value;
        private string userName="oracle";
        private string password="admin";
        public void addVaule(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.WriteLine("Oracle DB bağlantısı başarılı bir şekilde sonlandırıldı.");
        }

        public void deletevalue(string value)
        {
           this.value=null;

            Console.WriteLine("Veri tabanı üzerindeki bilgiler silindi!");
        }

        public void getValue()
        {

        }

        public int login(string userName, string passWord)
        {
            throw new NotImplementedException();
        }

        public void updatevalue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
