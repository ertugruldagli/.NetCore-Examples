using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal interface IDatabase
    {

        //bu interface sadece kodsuz olarak tanımlıyoruz. Yani şablon oluşturuyoruz.

        int login(string userName, string passWord);

        void close();

        void addVaule(string value);

        void deletevalue(string value);

        void updatevalue(string value);

        void getValue();
        
    }
}
