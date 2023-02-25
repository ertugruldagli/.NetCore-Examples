internal class Program
{
    private static void Main(string[] args)
    {
        //int toplam=0;
        //int i = 0;

        //while (i < 100)
        //{
        //    toplam += i;
        //    i++;

        //}
        //Console.WriteLine(toplam);




        //Console.Write("Lutfen sayinizi giriniz: ");
        //int sayi=Convert.ToInt32(Console.ReadLine());
        //int basamak = 0;

        //while(sayi>0)
        //{
        //    basamak++;

        //    sayi = sayi / 10;
        //}

        //Console.WriteLine("girdiginiz sayi " + basamak.ToString() + " basamaklıdır.");




        int toplam1 = 0;
        int sayac = 0;
        do
        {
            sayac++;
            toplam1 += sayac;

        } while (sayac < 100);

        Console.WriteLine("toplam: " + toplam1.ToString() + " \n" + "Sayac: " + sayac.ToString());



        Console.ReadKey();
    }
}