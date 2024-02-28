using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your final Percent? ");
        string numberGrade = Console.ReadLine();
        int number = int.Parse(numberGrade);
        if (number >= 90)
        {
            Console.WriteLine("You earned an A.");
        }
        else if (number >= 80 && number <= 89)
        {
            Console.WriteLine("You earned a B");
        }
        else if (number >= 70 && number <= 79)
        {
            Console.WriteLine("You earned a C.");
        }
        else if (number >= 60 && number <= 69)
        {
            Console.WriteLine("You earned a D.");
        }
        else
        {
            Console.WriteLine("You earned an F.");
        }

        if (number >= 70)
        {
            Console.WriteLine("Congratulations!  You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed this course.  Keep working at it!");
        }
    }
}