using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Random rnd = new Random();
    

    public Scripture()
    {
        string scripture = "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy days acknowledge him, and he shall direct thy paths.";
        string[] line = scripture.Split(" ");

        foreach (string word in line)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }

    public bool HideWord()
    {

        Word word =  _words[rnd.Next(_words.Count)];
        // same as word.GetHidden == false
        if (!word.GetHidden())
        {
            word.SetHidden();
            return true;
        }
        return false;
        
        

    }
    public void DisplayScripture()
    {
        foreach (Word word in _words) {
            word.Display();
            Console.Write(" "); 
        }
    }
    // Method that displays all the words
    //      for loop that calls the word.display()

    public bool AllWordsHidden() 
    {
        foreach (Word word in _words)
        {
            if (!word.GetHidden())
            {
                return false;
            }
        }
        return true;
    }
    // Method to return whether or not all the words are hidden
    //      for loop that checks if a word is still shown
    //          break and return false if there is a word still shown
        //       else return true
}