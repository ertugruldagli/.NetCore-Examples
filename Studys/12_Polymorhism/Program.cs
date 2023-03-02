using _;
using _12_Polymorhism;

internal class Program
{
    private static void Main(string[] args)
    {

       clsTutorials tutorials = new clsTutorials();

        tutorials.setTutorial(1,"C#"); //1. formunu kullanıyorum. 2 parametreli olan
        Console.WriteLine(tutorials.getTutorialName());

        tutorials.setTutorial("java"); //2. formunu kullnıyoruz tek parametreli olan

        Console.WriteLine();
    }
}