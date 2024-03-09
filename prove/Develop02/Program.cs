using System;
using System.Collections.Generic;
using System.IO;

//Some additions I made to exceed expectations is that I included
//the date and the time in the display.
//Also I labeled the prompt and journal entry when they are displayed.
//Also wrote labels as the files are loading and saving to instruct journal writer better what is happening.

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program:");
            Console.WriteLine("Please select from the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to select? ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {

                case "1":
                    WriteNewEntry(theJournal);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    LoadFromFile(theJournal);
                    break;
                case "4":
                    SaveToFile(theJournal);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("That is not an option, please try again.");
                    break;
            }
       
        }
    }

    static void WriteNewEntry(Journal myJournal)
    {
        string[] _prompts = {
            "Who was the most interesting person I interacted with?",
            "What was the best part of my day?",
            "How did I see the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "How did I show someone I loved them today?"
        };
        Random rand = new Random();
        int index = rand.Next(_prompts.Length);
        string prompt = _prompts[index];

        Console.WriteLine();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write(">");
        string Response = Console.ReadLine();
        string Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        myJournal.AddEntry(prompt, Response, Date);
    }
    static void SaveToFile(Journal myJournal)
    {
        Console.WriteLine();
        Console.WriteLine("Enter the filename to save:");
        string filename = Console.ReadLine();
        myJournal.SaveToFile(filename);
        Console.WriteLine();
        Console.WriteLine("Saving file...");
        Console.WriteLine();
    }
    static void LoadFromFile(Journal myJournal)
    {
        Console.WriteLine();
        Console.WriteLine("Enter the file to load:");
        string filename = Console.ReadLine();
        myJournal.LoadFromFile(filename);
        Console.WriteLine();
        Console.WriteLine("Loading journal...");
        Console.WriteLine();
    }

}    