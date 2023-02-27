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

        Hesapla(5,6);


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
    #endregion
}