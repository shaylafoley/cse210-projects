using System;
using System.Collections.Generic;
using System.Linq;
public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string Text)
    {
        _text = Text;
        _isHidden = false;

    }
    public void Hide()
    {
        //to hide the word
        _isHidden = true;
    }
    public void Show()
    {
        //method to show the word
        _isHidden = false;
    }
    public bool IsHidden()
    {
        //method to check if the word is hidden
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _isHidden ? "____" : _text;
    }
    
}