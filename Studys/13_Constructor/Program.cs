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

        clsEmployee emp1 = new clsEmployee();

        emp1.DisplayEmployee();


        #endregion















        Console.ReadKey();
    }
}