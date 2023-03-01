using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Classes
{
    internal class clsPersonel2
    {
        //değişkenler/Prop ların tanımlanması 

        public int PersonelID;
        public string Ad;
        public string Soyad;
        public string Unvan=null;
        public int Maas;
        public int IzınGunu;

        public void setPersonelBilgileri(string pAd, string pSoyad, int pMaas)
        {

            if (pAd.Length>0 && pSoyad.Length>0) // ad ve soyadın tam girilmesi kontrol ediliyor.
            {

                if (pMaas >= 2500)
                {

                    this.Ad = pAd;
                    this.Soyad = pSoyad;
                    this.Maas = pMaas;
                    this.IzınGunu = 14;



                    if (pMaas >= 10000 && pMaas <= 14000)
                    {
                        this.Unvan = "Kıdemli Personel";
                        this.IzınGunu = 20;
                    }
                    else if (pMaas >= 14001 && pMaas <= 15500)
                    {
                        this.Unvan = "Kıdemli+ Personel";
                        this.IzınGunu = 24;
                    }
                    else if (pMaas > 15500)
                    {
                        this.Unvan = "Uzman Personel";
                        this.IzınGunu = 30;
                    }
                    else
                    {
                        this.Unvan = "Jr. Personel";

                    }
                }
                else
                {
                    Console.WriteLine("Personel oluşturulamadı!");
                }

            }
            else
            {
                Console.WriteLine("İsim Bilgisi hatalı girilmiştir.");
            }


        }

        public  string getPersonelBilgileri()
        {
            if (Unvan!=null)
            {
                return $"Personel Ad: {Ad}\n Soyadı: {Soyad}\n Unvan: {Unvan}\n Maasi: {Maas} PNG Kina\n IzınGunu: {IzınGunu} gün";
            }
            else
            {
                return "Lütfen Personeli Oluşturunuz.";
            }
        }
        

    }
}
