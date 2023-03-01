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

        Console.WriteLine("Unitum Cerebris Commuitas Personel Listesi");
        Console.WriteLine("------------------------------------------");


        //nesne oluşturma
        clsPersonel1 per1= new clsPersonel1();

        // per1.setPersonelData(1,"ertu","hjhksjd","fsdsfsdf","sdfsdf",5600);

        per1.PersonelID = 1;
        per1.Ad = "Ertu";
        per1.Soyad = "Dagli";
        per1.TCKNo = "11951441286";
        per1.Bolum = "IT";
        per1.Maas = 1;

        per1.getPersonelData();


        clsPersonel1 per2 = new clsPersonel1(); //başka bir nesne oluşturuluyor.
        per2.PersonelID = 2;
        per2.Ad = "Uras";
        per2.Soyad = "Goceri";
        per2.TCKNo = "45657654351";
        per2.Bolum = "Post";
        per2.Maas = 1000;

        per2.getPersonelData();


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

            Console.WriteLine($"\n\nPersonel No: {PersonelID}\nAdı ve soyadı: {Ad} {Soyad}\nTCKNo: {TCKNo}\nBolum: {Bolum}\nMaas:{Maas} PNG Kina");
            
        }


    }
}