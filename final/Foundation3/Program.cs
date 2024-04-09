using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("545 Brockhurst St", "Sacramento", "CA", "USA");
        Lectures lecture1 = new Lectures("Lecture", "The Ulitmate Fasting Guide", "Learn all you can about the incredible world of fasting and how it will change your life.", "2/4/2025", "5:00 pm EST", address1, "Darrin Cabiliea", 500);

        Address address2 = new Address("76 Williams St", "Chicago", "IL", "USA");
        Receptions recept1 = new Receptions("Reception", "Wedding of Tyler and Melissa Coon", "Please come congratulate Tyler and Melissa on their marriage!", "12/19/2025", "6-8 pm MT", address2, "theCoons@gmail.com");

        Address address3 = new Address("2394 Kingston Ave", "Quebec City", "Quebec", "Canada");
        Outdoors outdoor1 = new Outdoors("Outdoor", "The Canadanian French", "Come visit the interesting life of the French Canadians, experience the beauty of Canada!", "5/25/2024", "3-9 pm MT", address3, "Cold Temperatures, Dress warm");

        Console.WriteLine();
        Console.WriteLine("First Event Info");
        Console.WriteLine("Standard Details");
        lecture1.GetStandardDetails();
        Console.WriteLine();

        Console.WriteLine("Full Details");
        lecture1.GetStandardDetails();
        lecture1.DisplayFullDetailEvent();
        Console.WriteLine();

        Console.WriteLine("Short Description");
        lecture1.GetShortDescription();
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Second Event Info");
        Console.WriteLine("Standard Details");
        recept1.GetStandardDetails();
        Console.WriteLine();

        Console.WriteLine("Full Details");
        recept1.GetStandardDetails();
        recept1.DisplayFullDetailEvent();
        Console.WriteLine();

        Console.WriteLine("Short Description");
        recept1.GetShortDescription();
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Third Event Info");
        Console.WriteLine("Standard Details");
        outdoor1.GetStandardDetails();
        Console.WriteLine();

        Console.WriteLine("Full Details");
        outdoor1.GetStandardDetails();
        outdoor1.DisplayFullDetailEvent();
        Console.WriteLine();

        Console.WriteLine("Short Description");
        outdoor1.GetShortDescription();
        Console.WriteLine();

    }
}