using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected string _duration;

    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name}!");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
        Console.WriteLine($"How long, in seconds,would you like for your session? ");
        
        string input = Console.ReadLine();

        if (int.TryParse(input, out int duration))
        {
            _duration = duration.ToString();
            Console.Clear();

            Console.WriteLine($"Your activity will be {_duration} seconds.");
        }
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000);
        ShowSpinner();

    }
    public void DisplayEndingMessage(string duration, string name)
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
       
        ShowSpinner();

        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the {name}.");
    
        ShowSpinner();
    }
    public void ShowSpinner()
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");  
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i=0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i >0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}