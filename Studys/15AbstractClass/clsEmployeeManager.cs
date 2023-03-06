using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15AbstractClass
{
    internal class clsEmployeeManager : clsEmployeeBaseManager
    {

        

        public clsEmployeeManager() //bu class ilk oluştuğunda default en taban title tanımını oluşturmak için 
        {
            setTitle("Beden İşçisi");
        }



        public override void doRaise() // çalışana zam yapan method 
        {
            double salary = getSalary(); //yani  oluşturulmuş  olan çalışanın o anki maaşını öğreniyorum.
            double raise = salary + 500; //raise --> zamlı maaş 

            setSalary(raise); //çalışanın yeni zmalı maaşı işlendi

        }

        public override void doRaise(double prmRaiseRate) // çalışana zam yapan (+prim) methot 
        {
            double salary = getSalary();
            double raise = salary + (salary*prmRaiseRate);

            setSalary(raise);  //yeni güncellenmiş maaş
        }
    }
}
