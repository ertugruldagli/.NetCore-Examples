using _11_inheritance;

internal class Program
{
    private static void Main(string[] args)
    {

        clsSubTutorials altsinif= new clsSubTutorials();

        altsinif.DersAdiBelirle(".net Tutorislas from linkedin.."); //çağırdığımız bu method alt sınıfta

        Console.WriteLine(altsinif.getTutorialName());// alt bir sınıftan üst bir sınıfın methodunu çağırabiliyoruz.
        //12. satıra geldiğinde yazmak içn getTutorials methodu çağırıyorum. Ama aslında bu method üst sınıfa alt sınıfın sanki bir metoduymuş gibi çağırabiliyorum (miras almasından dolayı)





        Console.ReadKey();

    }
}