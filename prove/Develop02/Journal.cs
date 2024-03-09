using System.Configuration.Assemblies;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string Prompt, string Response, string Date)
    {
        Entry entry = new Entry(Prompt, Response, Date);
        _entries.Add(entry);
    }
    public void LoadFromFile(string filename)
    {
        
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[1], parts[2], parts[0]));
                }
            }
        }
        
    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }
    
}