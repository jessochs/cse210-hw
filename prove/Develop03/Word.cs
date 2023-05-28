using System;

public class Word 
{
    private string _word;
    private bool _hidden;


    public Word(string word) {
        _word = word;
        _hidden = false;
    }

    public bool GetHidden()
    {
        return _hidden;
    }

    public void SetHidden()
    {
        _hidden = true;
    }
    
    public void Display()
    {
        
        if (_hidden == true)
        {
            foreach (char letter in _word)
                Console.Write("_");
        }
        else{
            Console.Write(_word);
        }
    }
    
}

