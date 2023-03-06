using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15AbstractClass
{

    //muhendis sınıfıdan personller için kullanıcakk class
    internal class clsEngineerManager : clsEmployeeBaseManager
    {

        public clsEngineerManager()
        {
            setTitle("muhendis");
        }
        public override void doRaise()
        {
            double salary = getSalary(); //yani  oluşturulmuş  olan çalışanın o anki maaşını öğreniyorum.
            double raise = salary + 2500; //raise --> zamlı maaş 

            setSalary(raise); //çalışanın yeni zmalı maaşı işlendi
        }

        public override void doRaise(double prmRaiseRate)
        {
            double salary = getSalary();
            double raise = salary + (salary * prmRaiseRate) + (salary % 2); // Prim kısmı

            setSalary(raise);  //yeni güncellenmiş maaş
        }
    }
}
