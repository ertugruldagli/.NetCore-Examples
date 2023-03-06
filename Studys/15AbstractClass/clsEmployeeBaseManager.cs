using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15AbstractClass
{
    internal abstract class clsEmployeeBaseManager
    {
        // çalışanlar için temel bilgilerin tutulacağı değişkenler

        private string name, surname,title; // özlük bilgileri
        private double salary; //maaş bilgisi
        private int annualLeave; //yıllık izin

        //çalışan kişilerin bilgilerini yazdıracağımız methodlar

        public  void getInfo()
        {
            if (annualLeave>0)
            {
                //Eğer çalışan herhangi bir şekilde  oluşturulmadıysa uyarı vermek için 
                Console.WriteLine($"< Abstract Company Employee >\n\n-> İsim: {name}\n Soyisim: {surname}\n-> Ünvan: {title}\n-> Maaş: {salary} PNG Kina\n-> Yıllık İzin : {annualLeave}");
            }
            else
            {
                Console.WriteLine($"< Employee Not Found >\n\n");
            }
        }

        //çalışan kişilerin bilgilerini set edeceğimiz metot 

        public void setInfo(string pName, string pSurname, double pSalary)
        {
            if(pName.Length>3 && pSurname.Length>=2) {

                if (pSalary>=8500)
                {
                    this.name = pName;
                    this.surname = pSurname;
                    this.salary = pSalary;

                    if (pSalary>=8500 && pSalary<=12000)
                    {
                        this.title = "Deneyimli " + title;
                        this.annualLeave = 20;
                    }
                    else if(pSalary > 12001 && pSalary <=15000)
                    {
                        this.title = "Kıdemli" + title;
                        this.annualLeave = 24;
                    }else if (pSalary>=15001)
                    {
                        this.title = "Uzman" + title;
                        this.annualLeave = 30;
                    }
                    else
                    {
                        this.annualLeave = 14;
                    }

                }
                else
                {
                    Console.WriteLine("<Eror>\n\n-> Çalışanınıza min 8500  vermeniz gerekmektedir. o yüz çalışan kaydı oluşturulmamıştır.");
                }
         
            }
            else
            {
                Console.WriteLine("<Eror>\n\n-> Çalışan iism/soyisim uzunluğu gerekli kriterler uymuyor... kontrol ediniz... \n ");
            }
        }


       
    }

}
