using System;
using System.Reflection;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Dizi tanımlama , değer atama, kullanma

        //int[] dizi = new int[20]; // 20 elemanlı dizi isimli bir dizi yaratılıyor

        //dizi[5] = 30; // 5.indexine bir değer atanıyor.

        //Console.WriteLine(dizi[5]); 

        // Şöyle de olabilir...

        //string[] dizi1 = { "Bir", "İki", "Üç" }; // string dizi daha tanımlanırken  ilk değerleride oluşturuluyor.

        //int[] dizi2 = { 2, -4, 6 };

        //float[] dizi3 = { 2f, 1.2f, 7f };

        // Not : Ancak bu şekilde dizi belirtimini sadece dizi tanımlamalarında kullanabiliriz. Örneğin aşağıdaki gibi bir kullanım hatalıdır:

        //int[] dizi;
        //dizi = { 1,2,3};

        //int[] dizi4 = new int[] { 1, 2, 3 };

        //Console.Write("1 ile 10 arasında bir sayı giriniz : ");

        //int boyut = Convert.ToInt32(Console.ReadLine());

        //int[] dizi5 = new int[boyut];

        //dizi5[5] = 30;

        //Console.WriteLine(dizi5[5]);

        // birden fazla dizi tanımlama
        //int[] dizi6 = new int[10], dizi7 = new int[20];


        //// Verilen bir string dizisini, ters sırada (sondan başa doğru) listeleme

        //string[] myUCC08Team = { "Nur", "Nergis", "Büşra", "Helin", "Özcan", "Berna", "Ferit Kaptan", "Nesibe", "Özdenur", "Aleyna", "İlker", "Ertuğrul", "Burak", "Mehmet Doğan", "scrat" };

        //int son = myUCC08Team.Length - 1;

        //for (int i = son; i >= 0; --i)
        //{
        //    Console.WriteLine(myUCC08Team[i]);
        //}


        #endregion

        #region for/foreach döngülerinin kullanımı
        // Verilen bir tamsayı dizisinin elemanlarının toplamını for ve foreach döngülerini kullanarak ayrı ayrı geliştiriniz

        // for
        //int[] sayilar1 = { 5, 6, 7, 8, 78, 45, 0, 30 };

        //int toplam1 = 0;

        //for (int index = 0; index < sayilar1.Length; ++index)
        //{
        //    toplam1 += sayilar1[index];
        //}

        //Console.WriteLine("for çevrimiyle elde edilen sonuç = " + toplam1);

        //// foreach
        //int[] sayilar2 = { 5, 6, 7, 8, 78, 45, 0, 30 };

        //int toplam2 = 0;

        //foreach (int i in sayilar2)
        //{
        //    toplam2 += i;
        //}
        //Console.WriteLine("foreach döngüsüyle elde edilen sonuç = " + toplam2);

        // Tanımlanan sayılar dizisi içerisindeki sayıların negatif, pozitif ve işaretsiz olma durumlarını yanına yazdırma

        //int pozitifadet=0,negatifadet=0,isaretsizadet = 0;

        //int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, -7, 43, 100 };

        //foreach (int sayi in sayilar)
        //{
        //    if (sayi > 0)
        //    {
        //        Console.WriteLine(sayi + " Pozitif");
        //        pozitifadet++;
        //    }

        //    else if (sayi < 0)
        //    {
        //        Console.WriteLine(sayi + " Negatif");
        //        negatifadet++;
        //    }

        //    else
        //    {
        //        Console.WriteLine(sayi + " İşaretsiz");
        //        isaretsizadet++;
        //    }

        //}

        //Console.WriteLine("\n\nPozitif sayı adedi : " + pozitifadet);
        //Console.WriteLine("\n\nNegatif sayı adedi : " + negatifadet);
        //Console.WriteLine("\n\nİşaretsiz sayı adedi : " + isaretsizadet);

        // Kullanıcıdan alınan metin içindeki sesli harf sayısını bulma

        //char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' }; // Daha sonra kullanacağım içinde tüm sesli harfleri içeren bir diziyi öncelikle bir oluşturuyorum.
        //char[] hangileri = new char[20] ; // bulduğum seslileri yerleştireceğim dizi 10 luk yarattım
        //int hindex=0; // hangileri dizisinin indexi

        //string metin=""; // ekrandan alacağım metin bilgisini tutmak için oluşturuyorum.

        //int adet = 0; // benim sesli harf adedini tutacak...

        //Console.WriteLine("Metin giriniz : ");

        //metin = Console.ReadLine().ToLower(); // ekrandan girilen metini okudum ve yerleştirdim ve tüm stringi küçük harfe çevirdim...çünkü elimdeki hazır dizi küçük harfli.

        //// girilen metnin ilk boyunu kullanacağım...

        //// birinci for dögüsü tanımlamış olduğum sesliler dizisi üzerinde dolaşacak.(kontrol amacıyla)
        //for (int i = 0; i < sesliler.Length; i++)
        //{
        //    // ikinci for çevrimi de ekrandan alınan metin için
        //    for (int j = 0; j < metin.Length; j++)
        //    {
        //        if (metin[j] == sesliler[i])  // girilen metini dizi gibi algılatıp benim sesliler dizisindeki bir karaktere uyuyor mu
        //        {
        //            hangileri[hindex] = metin[j]; // bulduğum sesli harfi başka bir diziye koyuorum
        //            hindex++;


        //            adet++; // seslileri tutuyor

        //            // not....indexof()
        //        }
        //    }
        //}

        //Console.WriteLine("Girmiş olduğunuz metinde {0} adet sesli harf vardır...",adet);

        //Console.WriteLine(hangileri);

        //// 10 elemanlı bir dizide bulunan pozitif, sıfır ve negatif değerlerin sayısını bulup yazma
        ///
        //int[] sayilar5 = { 10, -3, 5, 0, 33, -2, -60, 0, -20, -10 };

        //int sifirSay = 0, pozitifSay = 0, negatifSay = 0;

        //for (int x = 0; x < sayilar5.Count(); x++)
        //{
        //    if (sayilar5[x] < 0) // ulaşmış olduğum dizi gözündeki değer negatifse
        //        negatifSay++;
        //    else if (sayilar5[x] > 0) // pozitiflik kontrolu
        //        pozitifSay++;
        //    else
        //        sifirSay++; // ne negatif ne pozitif o zaman 0 dır...
        //}

        //Console.WriteLine("Sıfırların Sayısı : " + sifirSay);
        //Console.WriteLine("Negatiflerin Sayısı : " + negatifSay);
        //Console.WriteLine("Pozitiflerin Sayısı : " + pozitifSay);


        #endregion


        #region Çok boyutlu diziler

        //int[,] dizi9 = new int[3, 2]; // 2 boyutlu dizi

        //int[,] dizi10 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        //int[,,] dizi11 = new int[3, 2, 2]; // 3 boyutlu dizi

        //int[,,] dizi12 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };

        //// Dizi elemanlarını for döngüsü ile değiştirmek

        //for (int i = 0; i < 3; i++)
        //    for (int j = 0; j < 2; j++)
        //        for (int k = 0; k < 2; k++)
        //            dizi12[i, j, k] = 20;

        //// Düzensiz diziler
        //int[][] dizi13 = new int[3][];
        //dizi13[0] = new int[3];
        //dizi13[1] = new int[4];
        //dizi13[2] = new int[2];


        #endregion


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

        #region Başka bir örnek


        //int bolunecek, bolen;

        //try
        //{
        //    Console.Write("-> Bölünecek Değeri Girin: ");

        //    bolunecek = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("-> Bölen Değeri Girin: ");

        //    bolen = Convert.ToInt32(Console.ReadLine());

        //    double sonuc = (bolunecek / bolen);

        //    Console.WriteLine("-> {0} değerinin {1} değerine bölümünün sonucu: {3}", bolunecek, bolen, sonuc);
        //}
        //catch (DivideByZeroException e)
        //{
        //    Console.WriteLine("\n-> Hata! Sıfıra bölüm işlemi gerçekleştirilemez.\n-> Hata Mesajı: {0}\n", e.Message);
        //}
        //catch (FormatException e)
        //{
        //    Console.WriteLine("\n-> Hata! Sadece Int32 türünde veri girişi yapabilirsiniz.\n-> Hata Mesajı: {0}\n", e.Message);
        //}
        //catch (OverflowException e)
        //{
        //    Console.WriteLine("\n-> Hata! Değişgen sınırların aştınız.\n-> Hata Mesajı: {0}\n", e.Message);
        //}
        //catch (Exception e) // Geri kalan tüm hata durumlarını kapsar
        //{
        //    Console.WriteLine("\n-> Beklenmedik Bir Hata!\n-> Hata Mesajı: {0}\n", e.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("-> Finally Bloğu Çalışıyor.\n");
        //}

        #endregion



        Console.ReadKey();
    }
}