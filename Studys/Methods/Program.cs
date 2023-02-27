using System;
using System.Security.Cryptography;

internal class Program
{
    #region Methodlar

    private static void Hesapla()
    {
        Console.WriteLine("kısa kenar giriniz: ");
        int kk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("uzun kenar giriniz: ");
        int uk = Convert.ToInt32(Console.ReadLine());

        int alan = Convert.ToInt32(kk * uk);

        Console.WriteLine("alan: {0}", alan);

    }

    private static void Hesapla(int kisa, int uzun)
    {
        Console.WriteLine("kısa kenar giriniz: " + kisa);
        Console.WriteLine("uzun kenar giriniz: " + uzun);


        int alan = Convert.ToInt32(kisa * uzun);

        Console.WriteLine("alan: {0}", alan);
    }

    private static int HesaplaPmsiz()
    {
        //geriye deger donduren methodlar veya functionlar  da mutlaka return tanımı olmalıdır.
        Console.WriteLine("kısa kenar giriniz: ");
        int kk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("uzun kenar giriniz: ");
        int uk = Convert.ToInt32(Console.ReadLine());

        int alan = kk * uk;

        return alan;

        #endregion
    }

    private static int HesaplaPrmli(int kisa, int uzun)
    {
        Console.WriteLine("kısa kenar giriniz: " + kisa);
        Console.WriteLine("uzun kenar giriniz: " + uzun);

        int alan = Convert.ToInt32(kisa * uzun);

        Console.WriteLine("alan: {0}", alan);

        return alan;
    }


    private static int Topla(int a, int b)
    {

        return a + b;
    }
    private static int Cikarma(int a, int b)
    {

        return a - b;
    }
    private static int Carpma(int a, int b)
    {

        return a * b;
    }
    private static int Bolme(int a, int b)
    {

        return a / b;
    }

    private static void Hepsi(int a, int b)
    {
        int toplam = a + b;
        int cikar = a - b;
        int bolme = a / b;
        int carpma = a * b;

        Console.WriteLine("toplami: " + toplam);
        Console.WriteLine("cikar: " + cikar);
        Console.WriteLine("bolme: " + bolme);
        Console.WriteLine("carpma: " + carpma);
    }

    private static int DortIslem(int sayi1, int sayi2, string secenek)
    {
        int sonuc = 0;
        if (secenek == "+")
        {
            sonuc = sayi1 + sayi2;
        }
        else if (secenek == "-")
        {
            sonuc = sayi1 - sayi2;
        }
        else if (secenek == "*")
        {
            sonuc = sayi1 * sayi2;
        }
        else
        {
            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch
            {
                Console.WriteLine("sayi2 degeri 0 olamaz!");

                sonuc = sayi2 / sayi1;
            }
        }
        return sonuc;
    }


    private static int toplamaIslemi(int a, int b)
    {
        return a + b;
    }
    private static int toplamaIslemi(int a, int b, int c)
    {
        return a + b + c;
    }
    private static int toplamaIslemi(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }




    private static void Main(string[] args)
    {
        #region dikdörtgen alan hesabı
        //int k1, k2,alan;


        //Console.WriteLine("kısa kenar giriniz: ");
        //k1=Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("uzun kenar giriniz: ");
        //k2=Convert.ToInt32(Console.ReadLine());

        //alan = k1 * k2;

        //Console.WriteLine("alani: "+alan);
        #endregion

        #region 1. geriye deger döndürmeyen ve parametre almayan


        //Hesapla();


        #endregion

        #region 2. geriye deger döndürmeyen ve parametre alan

        //Console.WriteLine("kısa kenar giriniz: ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("uzun kenar giriniz: ");
        //int uk = Convert.ToInt32(Console.ReadLine());
        //Hesapla(kk,uk);

        //Hesapla(5,6);


        #endregion

        #region 3. geriye deger döndüren parametre almayan

        //int sonuc=HesaplaPmsiz(); //sonuc = alan (return'den gelen)
        //Console.WriteLine("Alan: {0}", sonuc);

        #endregion

        #region 4. geriye deger döndüren parametre alan

        //Console.WriteLine("kısa kenar giriniz: ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("uzun kenar giriniz: ");
        //int uk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("alan: {0}", HesaplaPrmli(kk,uk));

        //HesaplaPrmli(10,30);

        #endregion

        #region workout01
        //uygun method yapısı kullanarak dört işlem gerçekleştiriniz. Birden fazla method tanımlayabilirsiniz.

        //Console.WriteLine("s1 giriniz: ");
        //int s1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("s2 giriniz: ");
        //int s2 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("sonuc: "+ Topla(s1,s2));

        //Hepsi(s1,s2);

        #endregion

        #region workout01-ek
        //Console.WriteLine("kısa kenar giriniz: ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("uzun kenar giriniz: ");
        //int uk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("işlem türünü seçiniz:");
        //string secenek= Console.ReadLine();

        //DortIslem(kk, uk, secenek);

        //Console.WriteLine("işlem türü: "+secenek);
        //Console.WriteLine("sonuc :{0}", DortIslem(kk, uk, secenek));

        #endregion

        #region methodlarda aşırı yüklenme

        //Console.WriteLine("2li toplama:{0}", toplamaIslemi(45,45));
        //Console.WriteLine("3li toplama:{0}", toplamaIslemi(45, 45,45));
        //Console.WriteLine("4li toplama:{0}", toplamaIslemi(45, 45,45,45));



        #endregion

        #region workout02 - menu

        //ekrana seçenekli bir menü gelecek. seçeneklerim 1- hesap makinesi, 2-tek/çift kontrol.  buna göre methoları hazırlayınız

        #endregion


        Console.ReadKey();  
    }

  


}