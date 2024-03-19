using System;
using System.Runtime.InteropServices.Marshalling;

//Made the program with a lot of white space
//Labeled the first scripture and made sure it was visible each time
//Can make it so it hides different amounts of words each time
class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Memorizing Scriptures Game!");
        Console.WriteLine();
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him and he shall direct thy paths.";
        Scripture scripture1 = new Scripture(ref1, scriptureText);

        Console.WriteLine(ref1.GetDisplayText());
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine();

        //int wordsToHide = 2;
        while (!scripture1.IsCompletelyHidden())
        {

        Console.WriteLine("Progressively Hidden Scripture:");
        scripture1.HideRandomWords(4);
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Press enter to hide a word or type 'quit' to exit:");
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "quit")
            break;
        }
        
        Console.WriteLine("Congrats!  You memorized the scripture!");


    }
}