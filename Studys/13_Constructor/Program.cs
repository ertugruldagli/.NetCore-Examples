using _13_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {


        #region standart yapı


        //clsTest test = new clsTest();

        //Console.WriteLine($"i degeri: {test.i} - s degeri: {test.s} - b degeri: {test.b}");


        #endregion

        //Constructer Tipleri

        //Default or Parametersless Constructor --standart/parametresiz
        //Parameterized Constructor --parametreli
        //Copy Cosntructor --copy contructor
        //Static Consturctor --static
        //Private Constructor --private


        #region Default/Parametresiz

        //bu kurucular, bir programcı tarafından açıkça tanımlanabiliyor veya sınıf  altında açık...
        // Bu kurucular, bir programca tarafandan açakça tanamtanabitir veya sanaf altanda açik(explicitly) bir kurucu olmamasa nedeniyle // örtük(implicit) olarak tanimlanacaktir.
        //// Boylece, Varsayzlan veya Parametresiz Olusturucular yine iki tipte
        //sinaflandaralar.
        //// 1.System-Defined Default Constructor
        //// 2.User - Defined Default Constructor
        //// Eger programamazda açakça herhangi bir kurucu tanamlanmamassak, varsayalan olarak derleyici derleme sirasanda
        //// bir kurucu saglayacaktar. Bu yapacaya "varsayalan (default) kurucu" denir ve
        //varsayzlan kurucu parametresizdir.
        //// Varsayatan kurucu-yapact, veri yeterine (statik olmayan degiskenter)
        //varsayilan degerler atayacaktar.
        //// Bu olusturucu sisten tarafandan olusturuldugundan buna sistem tanaml1
        //varsayilan olusturucu da denir.

        //clsEmployee emp1 = new clsEmployee();   //kullanıcı tanımlı ctor
        //clsEmployee emp2 = new clsEmployee();

       
        //emp1.DisplayEmployee();
        //emp2.DisplayEmployee();


        #endregion


        #region Parametreli Ctor

        // Nesneyi kullanıcı tarafından verilen değerlerle dinamik olarak başlatmak istiyorsak veya bir sınıfın her bir örneğini
        // farklı bir değerler kümesiyle başlatmak istiyorsak, C#'ta Parameterized Constructor'ı kullanmamız gerekir.
        // Bu oluşturucular yalnızca programcılar tarafından tanımlanır. Yani, basit bir ifadeyle, geliştirici tarafından verilen
        // parametrelere sahip kurucu C#'ta Parametreli Yapıcı olarak tanımlanır.
        //
        // Yararı Nedir?
        // 
        // Parametreli bir kurucunun yardımıyla, sınıfın her bir örneğini farklı bir değerler kümesiyle başlatabiliriz.
        // Bu, parametreli yapıcı kullanarak, sınıfta oluşturulan farklı örneklerde farklı bir değer kümesi depolayabileceğimiz
        // anlamına gelir. Yani her nesneyi farklı değerlerle başlatabilme imkanı vermesidir.

        clsParametized prm1=new clsParametized(10);
        prm1.Display();


        clsParametized prm2 =new clsParametized(200);
        prm2.Display();



        #endregion


        #region Copy ctor

        // aynı değerlere sahip 


        #endregion









        Console.ReadKey();
    }
}