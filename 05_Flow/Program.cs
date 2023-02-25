
internal class Program
{
    private static void Main(string[] args)
    {

        //int c = 5, d = 7;

        //if (c<d)
        //{
        //    Console.WriteLine("c  degeri d degerinden buyuktur");
        //}
        //else
        //{
        //    Console.WriteLine("d degeri c den buyuktur");
        //}

        //int pass = 1234, gp;

        //Console.WriteLine("Parola giriniz: ");
        //gp=Convert.ToInt32(Console.ReadLine());

        //if (pass == gp)
        //{
        //    Console.WriteLine("Dogru parola girdiniz!");
        //}
        //else
        //{
        //    Console.WriteLine("Yanlıs parola girdiniz!");
        //}




        //string userName, userPass;
        //const string uN = "admin";
        //const string uP = "324324";

        //Console.WriteLine("Kullanici Adini giriniz: ");
        //userName= Console.ReadLine();

        //Console.WriteLine("Kullanici parolanızı giriniz: ");
        //userPass = Console.ReadLine();

        //if (userName == uN)
        //{
        //    if (userPass == uP){
        //        Console.WriteLine("Buyrun Geçin");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Girilen parola yanlış... kontrol et");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("girilen kullanıcı adı yanlış");
        //}




        //string ad,soyad;
        //Console.WriteLine("lütfen adinizi giriniz: ");
        //ad = Console.ReadLine();

        //switch (ad)
        //{
        //    case "Ertu":
        //        Console.WriteLine("lütfen soyadinizi giriniz: ");
        //        soyad = Console.ReadLine();

        //        Console.WriteLine("Grimis old. bilgi: " + ad + " " + soyad);
        //        break;
        //    default:
        //        Console.WriteLine("yanlıs format girildi");

        //            break;   //goto case 4: 4. case gider, goto komutu ile
        //}



        int toplam = 0;

        for (int i = 0;i < 11; i++) {
           // Console.WriteLine(i);
            toplam += i;
        }

        Console.WriteLine(toplam);


        string deger = "Ertugrul Dagli";

        for (int i = 0; i < deger.Length; i++)
        {
            Console.WriteLine(deger[i]);
        }





        ////faktoriyel hesabı

        //float s;
        //int si, f1;
        //bool a1 = true;

        //Console.WriteLine("bir sayi giriniz: ");
        //si=Convert.ToInt32(Console.ReadLine());

        //for (; a1 ;)
        //{
        //    Console.WriteLine("Lütfen faktoriyelini almak istediğiniz sayiyi giriniz: ");
        //    s = Convert.ToSingle(Console.ReadLine()); //tek haneliye çevirme

        //    si = (int)s; //casding işlemi 

        //    if (si!=s || s < 1)
        //    {
        //        Console.WriteLine("lütfen pozitif bir tam sayi giriniz: ");
        //        a1 = false;

        //    }
        //    else
        //    {
        //        a1 = true;

        //        for ( f1 = 1; si >1; si--)
        //        {
        //            f1 *= si;

        //        }
        //        Console.WriteLine("faktoriyel = {0}", f1);
        //    }

        //}




        //5e tam bölününen fakat 7e bölünmeyen sayıları ekran çıktısını bulan program.
        //int top = 0, sayac = 0;

        //for (int i = 0; i <= 1000; i++)      for (int i = 5; i <= 1000; i+=5)
        //{
        //    if (i % 5 == 0 && i % 7 != 0)
        //    {

        //        Console.WriteLine(i);
        //        sayac++;

        //        top += i;
        //    }

        //}
        //Console.WriteLine("toplam sayi adeti: {0} adettir... ", sayac);
        //Console.WriteLine("toplami: {0}'dir ", top);





        




        Console.ReadKey();
        
    }
}