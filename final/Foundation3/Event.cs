using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    
    protected string _type;


    public void DisplayStandard()
    {
        Console.WriteLine("Standard Event:");
        Console.WriteLine();
        
        Console.WriteLine($"You have been invited to {_title}.");
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");

    }

    public void DisplayFull()
    {   
        Console.WriteLine("Full Details Event:");
        Console.WriteLine();
        Console.WriteLine($"Type of event: {_type}");
        Console.WriteLine($"You have been invited to {_title}.");
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
    }

    public void DisplayShort()
    {
        Console.WriteLine("Short Event:");
        Console.WriteLine();
        Console.WriteLine($"You have been invited to {_type} {_title}.");
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
    }
}