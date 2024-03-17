using System;
using System.Collections.Generic;
using System.Linq;
public class Word
{
    public string _text{get; }
    private int _index {get; }
    public bool _isHidden{get; private set; }


    public Word(string Text, int Index)
    {
        _text = Text;
        _index = Index;
        _isHidden = false;

    }
    public void Hide()
    {
        _isHidden = true;
    }

    
}