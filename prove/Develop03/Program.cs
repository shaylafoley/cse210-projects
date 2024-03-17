using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Memorizing Scriptures Game!");
        Console.WriteLine();
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him and he shall direct thy paths.");
       

        Reference Display = new Reference("Proverbs", 3, 5, 6);
        string result = Display.GetDisplayText();
        Console.WriteLine(result);
        DisplayScripture(scripture);
        Console.WriteLine();
        Console.WriteLine("Press enter to hide a word or type 'quit' to exit:");
        string userInput = Console.ReadLine();
        

        while (userInput != "quit")
        {
            
            HideRandomWords(scripture);
            DisplayScripture(scripture);
        

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine();
                Console.WriteLine("Way to go!  You memorized the scripture!");
                Console.WriteLine();
                break;
            }
            
        }
        static void DisplayScripture(Scripture scripture)
        { 
            Console.WriteLine(scripture.GetFullScripture());
        }
        static void HideRandomWords(Scripture scripture)
        {
            //Random random = new Random();
            //int indexToHide = random.Next(0, scripture.Length);
            //scripture[Index] = new string('_', Word[indexToHide].Length);
            //string hiddenScripture = string.Join(" ", scripture);
            //Console.WriteLine(hiddenScripture);


            Random rand = new Random();
            List<Word> words = scripture.Words.ToList();

            int wordsToHide = Math.Min(1, words.Count(w=> !w._isHidden));
            for (int i=0; i < wordsToHide; i++)
            {
                int index = rand.Next(words.Count);
                words[index].Hide();
            }
        
        }
    }
}