using _09_Classes;
using System;
using System.Security.Cryptography;

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
        
        //clsOgrenci o1 =new clsOgrenci();
       
        //o1.OgrenciNo = 0;
        //o1.Ad = "ertugrul";
        //o1.Soyad = "dagli";
        //o1.Ders = "mat";
        //o1.Not = 56;

        //o1.getOgrenci();
        //o1.NotKontrol(o1.Not);



        #endregion

        #region personel örneği 2

        //bu örneğin amacı class yapısının bu source dosyasından farklı bir yerde tanımlanması ve kullanılması üzerine
        //bir şirket var
        //5 elemanı var ..  ad soyad ünvan maas ve izingunu
        //bir tane method olacak 
        //method içerisinde öncelikle  ad soyad bilgsini dolu olduğu durum da 
        //maasının miktarına göre o personelin kaç gün izin hakkı olacağı belirlencek
        //maas 2500 kina altındaysa düz personel izin günü 14
        //mass 10000-14000 arasındaysa kdemli personel ve izin günü 20 olacak
        //maas 14001-15500 arasındaysa kıdemli+ personel //izin günü 24 olacak olaca
        // maas 15500 üzeindeyse uzman personel olarak çıkış veren şekilde olacak izin günü 30 olacak
        //not: personelin maas bilgisinin belirlenmesi bilgisayara bırakılacak... random.. aralık 1000-20000 aralığı olsun.
        
        //nesneler oluştu
        clsPersonel2 ozcan=new clsPersonel2();
        clsPersonel2 ertugrul = new clsPersonel2();
        clsPersonel2 helin = new clsPersonel2();
        clsPersonel2 berna = new clsPersonel2();
        clsPersonel2 nergis = new clsPersonel2();
        clsPersonel2 nur = new clsPersonel2();
        clsPersonel2 ferit = new clsPersonel2();
        clsPersonel2 nesibe = new clsPersonel2();
        clsPersonel2 ozdenur = new clsPersonel2();
        clsPersonel2 aleyna = new clsPersonel2();
        clsPersonel2 ilker = new clsPersonel2();
        clsPersonel2 busra = new clsPersonel2();
        clsPersonel2 burak = new clsPersonel2();
        clsPersonel2 mehmet = new clsPersonel2();
        clsPersonel2 umit = new clsPersonel2();


        //bilgi doldurulması
        int maasilk = 1000;
        int maasson = 20000;
        Console.WriteLine("---------------Personeller-----------------");
        ozcan.setPersonelBilgileri("Özcan", "KARA", new Random().Next(maasilk, maasson));
        ertugrul.setPersonelBilgileri("Ertuğrul", "DAĞLI", new Random().Next(maasilk, maasson));
        helin.setPersonelBilgileri("Helin", "AYDIN", new Random().Next(maasilk, maasson));
        berna.setPersonelBilgileri("Berna", "ELKOVAN", new Random().Next(maasilk, maasson));
        nergis.setPersonelBilgileri("Nergis", "KETENCİ", new Random().Next(maasilk, maasson));
        nur.setPersonelBilgileri("Saadet Nur", "KARAKAŞ", new Random().Next(maasilk, maasson));
        ferit.setPersonelBilgileri("Muhammet Ferit", "ŞİMŞEK", new Random().Next(maasilk, maasson));
        nesibe.setPersonelBilgileri("Nesibe", "KOSANOĞLU", new Random().Next(maasilk, maasson));
        ozdenur.setPersonelBilgileri("Özdenur", "KOYUNCU", new Random().Next(maasilk, maasson));
        aleyna.setPersonelBilgileri("Aleyna", "ÖZ", new Random().Next(maasilk, maasson));
        ilker.setPersonelBilgileri("İlker", "KAPLAN", new Random().Next(maasilk, maasson));
        busra.setPersonelBilgileri("Büşra", "KÖSE", new Random().Next(maasilk, maasson));
        burak.setPersonelBilgileri("Burak", "ACAR", new Random().Next(maasilk, maasson));
        mehmet.setPersonelBilgileri("Mehmet Doğan", "ERBAY", new Random().Next(maasilk, maasson));
        umit.setPersonelBilgileri("Ümit", "KARAÇİVİ", new Random().Next(maasilk, maasson));


        Console.WriteLine(ozcan.getPersonelBilgileri());
        Console.WriteLine(ertugrul.getPersonelBilgileri());
        Console.WriteLine(helin.getPersonelBilgileri());
        Console.WriteLine(berna.getPersonelBilgileri());
        Console.WriteLine(nergis.getPersonelBilgileri());
        Console.WriteLine(nur.getPersonelBilgileri());
        Console.WriteLine(ferit.getPersonelBilgileri());
        Console.WriteLine(nesibe.getPersonelBilgileri());
        Console.WriteLine(ozdenur.getPersonelBilgileri());
        Console.WriteLine(aleyna.getPersonelBilgileri());
        Console.WriteLine(ilker.getPersonelBilgileri());
        Console.WriteLine(busra.getPersonelBilgileri());
        Console.WriteLine(burak.getPersonelBilgileri());
        Console.WriteLine(mehmet.getPersonelBilgileri());
        Console.WriteLine(umit.getPersonelBilgileri());



        ////bu sınıf içinde oluşturulmuş sınıf
        //clsPersonel2a per2=new clsPersonel2a();
        //per2.PersonelAd = "ERtugrul";
        //per2.PersonelSoyad = "dagli";
        //per2.Unvan = "Kıdemli Uzman";

        //Random rnd = new Random();
        //per2.Maas = rnd.Next(1000, 20000);


        //per2.getPersonel();
        //per2.PersonelMaas(per2.Maas);


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
    class clsOgrenci
    {
        public int OgrenciNo;
        public string Ad;
        public string Soyad;
        public string Ders;  // işlem yapılmayacağı(*+-/) için bellekten kazanç sağlamak adına string veri tipinde değer döndürür.
        public int Not;



        public void getOgrenci()
        {

            Console.WriteLine($"\n\nogrenci No: {OgrenciNo}\nAdı ve soyadı: {Ad} {Soyad}\nDers: {Ders}\nNotu: {Not}");
        }

        public void NotKontrol(int Not)
        {

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
    #endregion

    class clsPersonel2a
    {
        public string PersonelAd;
        public string PersonelSoyad;
        public string Unvan;
        public int Maas;
        public int IzınGunu=14;

        public void getPersonel()
        {

            Console.WriteLine($"Adı ve soyadı: {PersonelAd} {PersonelSoyad}\nUnvan: {Unvan}\nMaas: {Maas}");
        }

        public void PersonelMaas(int Maas)
        {

          

            if (Maas>=2500 && Maas<=10000)
            {
                Console.WriteLine("Düz Personel  izin gün sayısı: " + IzınGunu);
            }
            else if (Maas>=10001 && Maas<=14000)
            {
                Console.WriteLine("Kıdemli Perosnel  izin gün sayısı : 20");
            }
            else if (Maas >= 14001 && Maas <= 15000)
            {
                Console.WriteLine("Kıdemli Perosnel+  izin gün sayısı : 24");
            }else if (Maas>15500)
            {
                Console.WriteLine("Uzman izin gün sayısı : 30");
            }
           
        }
    }


  


}


