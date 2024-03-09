using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        while (true)
        {
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
                    theJournal.Display();
                    break;
                case "3":
                    SaveToFile(theJournal);
                    break;
                case "4":
                    LoadFromFile(theJournal);
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

        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine(">");
        string Response = Console.ReadLine();
        string Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        myJournal.AddEntry(prompt, Response, Date);
    }
    static void SaveToFile(Journal myJournal)
    {
        Console.WriteLine("Enter the filename to save:");
        string filename = Console.ReadLine();
        myJournal.SaveToFile(filename);
    }
    static void LoadFromFile(Journal myJournal)
    {
        Console.WriteLine("Enter the file to load:");
        string filename = Console.ReadLine();
        myJournal.LoadFromFile(filename);
    }

}    