using System;
using System.Reflection;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {

        #region metinin içinceki seslileri say
        ////Kullanıcıdan alınan bir metin içerisindeki sesli harf sayilarini ekrana yazdırma.
        //char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        //char[] hangileri = new char[10];

        //string metin;
        //int sayac = 0;

        //int hindex = 0;


        //Console.WriteLine("Bir metin giriniz: ");
        //metin = Console.ReadLine().ToLower();// tüm harfleri küçük harfe çevir.


        //for (int i = 0; i < sesliler.Length; i++)//sesliler dizisi üzerinde dolaşacak.
        //{
        //    for (int j = 0; j < metin.Length; j++)//metinin uzunluğuna kadar döndürecek
        //    {
        //        if (metin[j] == sesliler[i])// eğer metin içindeki karakterler, sayilar dizisi içindeki karakterlere eşitse kaç adet olduğunu ekrana yaz
        //        {

        //            hangileri[hindex] = metin[j];
        //            hindex++;
        //            sayac++;
        //        }

        //    }
        //}

        //Console.WriteLine("Metin içerisindeki sesli harfler: " + hangileri);
        //Console.WriteLine("Toplam sesli harf adeti: {0}", sayac);

        #endregion

        #region  çok boyutlu diziler and Array


        //Array metinsel = Array.CreateInstance(typeof(string), 81);

        //metinsel.SetValue("İstanbul", 0);
        //metinsel.SetValue("Ankara", 1);
        //metinsel.SetValue("İzmir", 2);
        //metinsel.SetValue("Bursa", 3);
        //metinsel.SetValue("Manisa", 4);
        //metinsel.SetValue("Kastamonu", 5);
        //metinsel.SetValue("Muğla", 6);
        //metinsel.SetValue("Bolu", 7);

        //Console.WriteLine("--- Sırasız Dizi");

        //foreach (string sehirisim in metinsel)
        //    Console.Write(sehirisim + " ");


        //Console.WriteLine("--- Sıralı Dizi");


        //Array.Sort(metinsel);

        //foreach (string sehirisim in metinsel)
        //{
        //    Console.WriteLine(sehirisim + " ");
        //}

        //Console.WriteLine("---ters dizi");


        //Array.Reverse(metinsel);

        //foreach (string sehirisim in metinsel)
        //{
        //    Console.WriteLine(sehirisim + " ");
        //}

        //Console.WriteLine("");


        ////Dizilerde arama  (Binary Serach)

        //int[] dizi28 = { 500, 68, 234, 56, 2 };

        //Array.Sort(dizi28); 

        //foreach (int i in dizi28)
        //    Console.WriteLine(i+ " ");

        //Console.WriteLine("dizi28 Index : " + Array.BinarySearch(dizi28,56));
        //// Binary Search Methodu,  bir nesneyi (56) dizi içerisinde arama işlemi yapar. Eğer bulursa bulduğu nesnenin indisini tutar; bulamazsa negatif deger döndürür.
        ////Eğer Binary Search kullanılması isteniyorsa öncelikli olarak diziyi bir sort fonksiyonu ile sıralama işlemi yapılması gerekmektedir.

        //if (Array.BinarySearch (dizi28,561)<0)

        //{
        //    Console.WriteLine("Aramis oldugunuz deger dizide yoktur.");
        //}

        #endregion

        #region hata oluşabilecek durum

        //int a = 100;
        //int b = 0;
        //Console.WriteLine("{0} / {1} işleminin sonucu = {2} ", a,b,a/b);

        #endregion

        #region hata avcısı
        //int c = 100;
        //int d = 0;

        //try
        //{
        //    Console.WriteLine("{0} / {1} işleminin sonucu = {2} ", c, d, c / d);
        //}
        //catch 
        //{
        //    if (c != 0 && d==0)
        //    {
        //        d = c / 100;

        //        Console.WriteLine("D degeri hata oluşturduğundan dolayı güncellenmiş ve {0} değeri atanmıştır.\n   {1}/{2} işleminin sonucu = {3} ' tür ", d, c, d,c / d);
        //    }
        //    else if(c==0 && d != 0)
        //    {
        //        c = d * 10;

        //        Console.WriteLine("C degeri hata oluşturduğundan dolayı güncellenmiş ve {0} değeri atanmıştır.\n   {1}/{2} işleminin sonucu = {3} ' tür ", c, c, d, c / d);

        //    }
        //    else if(d == 0 && c==0)
        //    {
        //        c = 50;
        //        d = 10;
        //        Console.WriteLine("\n   {0}/{1} işleminin sonucu = {2} ' tür ", c, d, c / d);
        //    }

        //}

        #endregion


        #region Hata Metodları
        byte deger;
        try
        {
            Console.WriteLine("Byte türünden bir değer giriniz:");
            deger = Convert.ToByte(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Message: {0}\n Source: {1}\nStackTrace: {2}\n TargetSite: {3}", e.Message, e.Source, e.StackTrace, e.TargetSite);
            
        }




        #endregion

        Console.ReadKey();
    }
}