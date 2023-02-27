internal class Program
{
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

        int sonuc=HesaplaPmsiz(); //sonuc = alan (return'den gelen)
        Console.WriteLine("Alan: {0}", sonuc);

        #endregion

        #region 4. geriye deger döndüren parametre alan


        #endregion





        Console.ReadKey();  
    }

    #region Methodlar

    private static void Hesapla()
    {
        Console.WriteLine("kısa kenar giriniz: ");
        int kk =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("uzun kenar giriniz: ");
        int uk = Convert.ToInt32(Console.ReadLine());

        int alan = Convert.ToInt32(kk * uk);

        Console.WriteLine("alan: {0}",alan);

    }

    private static void Hesapla(int kisa, int uzun)
    {
        Console.WriteLine("kısa kenar giriniz: "+ kisa);
        Console.WriteLine("uzun kenar giriniz: "+uzun);
         

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
}