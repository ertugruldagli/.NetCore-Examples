using _11_inheritance;

internal class Program
{
    private static void Main(string[] args)
    {

        clsSubTutorials altsinif= new clsSubTutorials();

        altsinif.renameTutorial(".net Tutorislas from linkedin.."); //çağırdığımız bu method alt sınıfta

        Console.WriteLine(altsinif.getTutorialName());





        Console.ReadKey();

    }
}