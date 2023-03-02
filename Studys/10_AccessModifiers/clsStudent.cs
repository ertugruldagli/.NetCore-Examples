using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccessModifiers
{
    internal class clsStudent
    {
        private string name="Ertu";
        

        public void getName()
        {
            Console.WriteLine("öğrencinin adı: {0}", this.name);
        }

    }
}
