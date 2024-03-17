using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture


{
    public Reference _reference {get; set;}
    public string _text{get;set;}
    public List<Word> Words;

    public Scripture(string Reference, string text)
    {
        string _reference = Reference;
        _text = text;

        Words = text.Split(' ').Select((word, index) => new Word(word, index)).ToList();
        
    }
    
    public string GetFullScripture()
    {
        return $"{string.Join(" ", Words.Select(w => w._isHidden ? "______" : w._text))}";
    }
    public bool AllWordsHidden()
    {
       return Words.All(w => w._isHidden);
    }

}