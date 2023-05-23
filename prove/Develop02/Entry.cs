using System;

public class Entry 
{
    // DateTime _theCurrentTime = DateTime.Now;
    public string _date = "";
    
    public string dateText;
    public string _prompt = "";
    public string _response = "";

    public Entry(){}
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // WriteEntry
    //  Set the dateText
    //  Get random prompt
    // Display prompt
    //  Get response
    public void Display()
    {
        Console.WriteLine($"{_date} {_prompt} {_response}");
    }

}