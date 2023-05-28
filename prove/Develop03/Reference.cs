using System;

public class Reference 
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse) {
        
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, string chapter, string verse, string endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        string place;
        if (_endVerse == null)
        {
            place = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            place = $"{_book} {_chapter}:{_verse} - {_endVerse}";
        }
            

        return place;
    }
}   
