﻿using _10_AccessModifiers;

internal class Program : clsMovies //Kalıtım (ınheritence)
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

        #region protected 

      clsMovies movies = new clsMovies();

      Program program= new Program();

      Console.WriteLine($"Movie Name: {program.movieName}");


        #endregion

















        Console.ReadKey();
    }
}