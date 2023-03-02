using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsTest
    { //ctor kısa ismi 

        public int i; //default: 0
        public string s; //defalt: ""
        public bool b; //defalt: false

        //class ismi ile aynı olacak bir method aslında.
        //ctor, clas devrye girdiğinde otomatik çalışıan  bir methodur.
        //değişik durumlarda initial işlemler yapmak için kullanılır.


        public clsTest()
        {
            i = 0;
            s = "Merhaba";
            b= true;
        }
    }
}
