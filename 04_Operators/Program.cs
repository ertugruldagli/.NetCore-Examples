using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Matematiksel Operators

        ////mod alma operatörü 
        //int a = 5 % 2;
        //Console.WriteLine("Sonuç: " + a);


        ////değişik durum 00; işlem yapılan her iki operand farklı türdeyse sonuç daha üst kapasiteli olan değişkende tutulur.

        //float b = 5 / 2f;//5 sayısı da integer olarak yazılsa bile float değişken türünde yazılır. SOnuç ondalık olarak çıktı sağlar.
        //Console.WriteLine("değişik durum 00 sonucu: "+ b.ToString());



        ////değişik durum 01

        //float c = 2 / 5 / 2f; //bu durumda sonuc 0 çıkacaktır. Çünkü float işlem ypaılırken zaten sonuç sıfırlanmıştı.
        //Console.WriteLine("değişik durum 01 sonucu: " + c.ToString());

        ////değişik durum 02

        //float d = 2f / 5 / 2;// işlemler sırası sol taraftan ondalıklı olarak başladığı için sonuç ondaklıklı çıkacaktır.
        //Console.WriteLine("değişik durum 02 sonucu: " + c.ToString());

        #endregion

        #region bir artırma ve bir eksiltme operatörleri
        //int fonceki = 5;
        ////Console.WriteLine("önceki değeri : " + fonceki.ToString()); //5
        //int fsonraki = ++fonceki;// öncen arttırma işlemi yapar

        //Console.WriteLine("önceki değeri : " + fonceki.ToString()); //6
        //Console.WriteLine("sonraki değeri: " + fsonraki.ToString());//6

        //int gonceki = 20;
        ////Console.WriteLine("önceki değeri : " + gonceki.ToString()); //
        //int gsonraki = gonceki++;//
        //Console.WriteLine("önceki değeri : " + gonceki.ToString()); //6
        //Console.WriteLine("sonraki değeri: " + gsonraki.ToString());//6
        #endregion


        #region uygulama

        //int h = 5;
        //int i = h++;
        //int j = i--;
        //int k = 10;
        //int l = --k;
        //Console.WriteLine("Sonuclar: h degeri={0}\ti degeri{1}\tj degeri={2}\tl  degeri{3}\n",h,i,j,l);



        #endregion


        #region karşılaştırma operatorleri 
        bool m = 4 < 6;
        bool n = 6 > 5;
        bool o = 7 <= 7;
        bool p = 9 >= 13;
        bool q = 10 == 14;
        bool r = 1 != 8;
        Console.WriteLine("Sonuclar: m degeri={0}\tn degeri{1}\to degeri={2}\tp  degeri{3}\tq", m, n, o, p);

        #endregion


        #region as operatörü
        // tüm değişken türlerinden obje değişken türüne ve object türünden de referans değişkenlere dönşüm işlemini yapar. Eğer olursa dönüşüm olmazsa null değer geri döner.

        object s = "50";
        string t = s as string;
        int u = 50;
        object v = u as object;




        #endregion 


        Console.ReadKey();
    }
}