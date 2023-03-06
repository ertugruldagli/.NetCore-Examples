using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15AbstractClass
{

    //burası elemanı yoktan var edecek... Personel listesi oluşturma gibi

    internal class clsCreateEmployeeManage
    {
        public clsEmployeeBaseManager employeeBaseManager;
        private string name, surName;
        private double salary; 

        public void Create()
        {
            Console.WriteLine("<Create Employee Manager>\n\n -> Çalışanın ismi: ");
            name = Console.ReadLine();

            Console.WriteLine("Çalışanın soyismi: ");
            surName = Console.ReadLine();

            Console.WriteLine("-> Çalışanın Maaşı: ");
            salary = Convert.ToInt32(Console.ReadLine());


            employeeBaseManager.setInfo(name,surName,salary);
        }

        public void getInfo()
        {
            employeeBaseManager.getInfo();
        }

        public void doRaise()
        {
            employeeBaseManager.doRaise();//Normal çalışan için zam methodunu çağırıyoruz. 
            Console.WriteLine($"Zam uygulandı \n\n Yeni maaş: {employeeBaseManager.getSalary} PNG kina \n\n" );
        }

        public void doRaise(double pRaiseRate)
        {
            employeeBaseManager.doRaise(pRaiseRate);

          
            Console.WriteLine($"primli Zam uygulandı \n\n Yeni maaş: {employeeBaseManager.getSalary} PNG kina \n\n");
        }
    }
}
