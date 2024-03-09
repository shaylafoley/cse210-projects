using System.Net;
using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _entryText {get; set;}

    public Entry(string Prompt, string Response, string Date)
    {
        _promptText = Prompt;
        _entryText = Response;
        _date = Date;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Journal Entry: {_entryText}");
        Console.WriteLine();
    }
}