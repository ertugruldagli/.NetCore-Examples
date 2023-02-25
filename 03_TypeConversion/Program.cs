internal class Program
{
    private static void Main(string[] args)
    {
        #region bilincsiz tur donusumu
       
        byte a = 10;
        short b= 20;
        sbyte c= 30;

        int toplam=a+b+c;

        Console.WriteLine(toplam);

        string e = "Proje ISkur";
        char k = 'a';
        object g = e + " " + k + " " + toplam;
        long h = toplam;
        float i = h;
        double j = i;
        double f = 21.6;
        
        Console.WriteLine("1. durum : "+ toplam.ToString());
        Console.WriteLine("2. durum : "+ g.ToString());
        Console.WriteLine("3. durum : "+ (h+f));
        Console.WriteLine("4. durum: "+ h+f);

        #endregion


        #region Bilinçli tur donusumu

        char l = 'H';
        int m = l;

        Console.WriteLine("5. durum: " + m.ToString());
        Console.WriteLine("\n\n\t");
        Console.WriteLine();

        int r = 259;
        byte s = (byte)r;
        Console.WriteLine("6. durum: " + s);


        #endregion

        Console.ReadKey();
        
    }
}