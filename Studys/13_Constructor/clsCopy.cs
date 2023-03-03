using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsCopy
    {

        int x;

        public clsCopy(int i)
        {
            x = i;
            Console.WriteLine($"Parametreli ctor/yapıcı çağırıldı... Parametre degeri: {i}");
        }

        public void Display()
        {
            Console.WriteLine($"X değişkenin değeri: {x}");
        }
    }
}
