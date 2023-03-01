using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    { 
        //Personel kayıt sistemi: clsPersonel; persosnelID, ad,soyadı, tc, maas
        //Personel kaydı oluşturmak için setPerosnelData isimli method oluşturulacak. 
        //Personel bilgilerini göstermek için getPersonelData isimli bir method oluşturulacak.
        //Sınıf tanımlaması bititkten sonra işlemler orada tanımlanacak. 


        //Personel Bilgileri 1



        Console.ReadKey();

    }



    class clsPersonel1
    {
        //Sınıfın özelliklerini (properteis) tanımlama 

        //Properteis
        public int PersonelID;
        public string Ad;
        public string Soyad;
        public string TCKNo;  // işlem yapılmayacağı(*+-/) için bellekten kazanç sağlamak adına string veri tipinde değer döndürür.
        public string Bolum;
        public int Maas;

        public void setPersonelData(int pID, string pAd, string pSoyad, string pTCKNo, string pBolum, int pMaas)
        {
            //bu method obje/class bilgilerini set etmek için kullanılacaktır. 
            PersonelID= pID;
            Ad= pAd;
            Soyad= pSoyad;
            TCKNo= pTCKNo;
            Bolum= pBolum;
            Maas= pMaas;
        }

        public void getPersonelData()
        {

            Console.WriteLine($"\n\nPersonel No: {PersonelID}\nAdı ve soyadı: {Ad} {Soyad}\n TCKNo: {TCKNo}\nBolum: {Bolum}\nMaas:{Maas} PNG Kina");
            
        }


    }
}