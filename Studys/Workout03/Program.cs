internal class Program
{

    public static void Menu()
    {
        string sec;
        Console.WriteLine("Hangisini Seçmek İstersiniz\n Hesap makinesi için: H \n TekCift Sayilar için : T");
        sec= Console.ReadLine();

        if(sec=="H"){
            Console.WriteLine("1.sayi giriniz: ");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayi giriniz: ");
            int uk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("işlem türünü seçiniz:");
            string secenek = Console.ReadLine();

            HesapMak(kk, uk, secenek);

            Console.WriteLine("işlem türü: " + secenek);
            Console.WriteLine("sonuc :{0}", HesapMak(kk, uk, secenek));
        }
        else if (sec=="T" )
        {
            Console.WriteLine("bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine(  TekCift(sayi));

        }
    }
    public static string TekCift(int sayi)
    {
        string sonuc;

        if (sayi % 2 == 0)
        {
            sonuc = "bu sayi cifttir.";
            
        }
        else
        {
            sonuc = "bu sayi tektir.";
            
        }

        return sonuc;
    }
    private static int HesapMak(int sayi1, int sayi2, string secenek)
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



    private static void Main(string[] args)
    { //ekrana seçenekli bir menü gelecek. seçeneklerim 1- hesap makinesi, 2-tek/çift kontrol.  buna göre methoları hazırlayınız.. menüyü ekrana getirme hesap mak. tekcift kontrol

        Menu();
      
    }
}