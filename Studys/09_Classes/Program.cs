﻿using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {


        #region personel örneği 1

        //Personel kayıt sistemi: clsPersonel; persosnelID, ad,soyadı, tc, maas
        //Personel kaydı oluşturmak için setPerosnelData isimli method oluşturulacak. 
        //Personel bilgilerini göstermek için getPersonelData isimli bir method oluşturulacak.
        //Sınıf tanımlaması bititkten sonra işlemler orada tanımlanacak. 


        ////Personel Bilgileri 1

        //Console.WriteLine("Unitum Cerebris Commuitas Personel Listesi");
        //Console.WriteLine("------------------------------------------");


        ////nesne oluşturma
        ////manuel/method yolu olarak doldurma
        //clsPersonel1 per1= new clsPersonel1();

        //per1.setPersonelData(99999,"ertu","caner","155464531","HR",5600);
        //per1.getPersonelData();

        //per1.setPersonelData(33333,"ahmet","sahin","45445498","ıt",8562);
        //per1.getPersonelData();

        //per1.PersonelID = 1;
        //per1.Ad = "Ertu";
        //per1.Soyad = "Dagli";
        //per1.TCKNo = "11951441286";
        //per1.Bolum = "IT";
        //per1.Maas = 1;

        //per1.getPersonelData();


        //clsPersonel1 per2 = new clsPersonel1(); //başka bir nesne oluşturuluyor.
        //per2.PersonelID = 2;
        //per2.Ad = "Uras";
        //per2.Soyad = "Goceri";
        //per2.TCKNo = "45657654351";
        //per2.Bolum = "Post";
        //per2.Maas = 1000;

        //per2.getPersonelData();


        //clsPersonel1 per3 = new clsPersonel1(); //başka bir nesne oluşturuluyor.
        //per3.PersonelID = 3;
        //per3.Ad = "AHmet";
        //per3.Soyad = "İlhan";
        //per3.TCKNo = "23135468751";
        //per3.Bolum = "Engineer";
        //per3.Maas = 2500;

        //per3.getPersonelData();
        #endregion

        #region Öğrenci örneği
        //Bir class oluşturulacak; clsOgrenci: ogrNO,ogrAD,ogrSoyad, ders ve dersntu
        //2 tane method olacak 1 tanesi ogrencinin verilerini tutacak, diğeri ise ogrencinin aldığı nota göre 50 kontrol degeri ile geçti kaldı çıktısı verilsin.

        clsOgrenci o1 =new clsOgrenci();
        o1.setOgrenci(1748,"ertu", "dagli","mat",85);
        o1.getOgrenci();


        #endregion

        Console.ReadKey();

    }


    #region class and method
    class clsPersonel1
    {
        //Sınıfın özelliklerini (properteis) tanımlama 

        //Properteis
        //public int PersonelID;
        //public string Ad;
        //public string Soyad;
        //public string TCKNo;  // işlem yapılmayacağı(*+-/) için bellekten kazanç sağlamak adına string veri tipinde değer döndürür.
        //public string Bolum;
        //public int Maas;

        //public void setPersonelData(int pID, string pAd, string pSoyad, string pTCKNo, string pBolum, int pMaas)
        //{
        //    //bu method obje/class bilgilerini set etmek için kullanılacaktır. 
        //    PersonelID= pID;
        //    Ad= pAd;
        //    Soyad= pSoyad;
        //    TCKNo= pTCKNo;
        //    Bolum= pBolum;
        //    Maas= pMaas;
        //}

        //public void getPersonelData()
        //{

        //    Console.WriteLine($"\n\nPersonel No: {PersonelID}\nAdı ve soyadı: {Ad} {Soyad}\nTCKNo: {TCKNo}\nBolum: {Bolum}\nMaas:{Maas} PNG Kina");
            
        //}


    }
    #endregion

     class clsOgrenci
    {
        public int OgrenciNo;
        public string Ad;
        public string Soyad;
        public string Ders;  // işlem yapılmayacağı(*+-/) için bellekten kazanç sağlamak adına string veri tipinde değer döndürür.
        public int Not;

        public void setOgrenci(int oNO, string oAd, string oSoyad, string oDers, int oNot )
        {
            //bu method obje/class bilgilerini set etmek için kullanılacaktır. 
          OgrenciNo= oNO;
            Ad = oAd;
            Soyad= oSoyad;
            Ders= oDers;
            Not = oNot;
         
        }

        public void getOgrenci()
        {

            Console.WriteLine($"\n\nogrenci No: {OgrenciNo}\nAdı ve soyadı: {Ad} {Soyad}\nDers: {Ders}\nNotu: {Not}");

            if (Not >= 50)
            {

                Console.WriteLine("geçti");
            }
            else
            {
                Console.WriteLine("kaldı");
            }

        }

    }


}