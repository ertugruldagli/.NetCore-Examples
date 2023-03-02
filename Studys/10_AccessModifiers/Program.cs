using _10_AccessModifiers;

internal class Program
{
    private static void Main(string[] args)
    {

        #region public 


        clsTutorials tutorials = new clsTutorials(); //classtan örnekleme yapıldı nesne oluşturuldu.

        tutorials.setTutorial(1,"csharp eğitimi");
        Console.WriteLine("Eğitim adı: {0}", tutorials.getTutorialName());

        #endregion

        #region private 

        clsStudent student = new clsStudent();
        student.getName();
        
        

        #endregion

        Console.ReadKey();
    }
}