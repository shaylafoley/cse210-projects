using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Memorizing Scriptures Game!");
        Console.WriteLine();
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(ref1, "Trust the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him and he shall direct thy paths.");

        Console.WriteLine(ref1.GetDisplayText());
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press enter to hide a word or type 'quit' to exit:");
        string userInput = Console.ReadLine();
        while (userInput != "quit")
        {
            scripture1.HideRandomWords(2);

        
            Console.WriteLine(scripture1.GetDisplayText());
            if (scripture1.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations!  You memorized the scripture!");
            }
            else
            {
                Console.WriteLine("Keep Going!");
            }

    }
}