using System;

public class Outdoor : Event 
{
    private string _weather = "Partly cloudy";
    private EventAddress address3 = new EventAddress("Various locations", "Unknown", "United Kingdom", "00001");

    public Outdoor()
    {
        _title = "Tri Wizard Tournament";
        _description = "Come see the best three wizards battle for the tri wizard cup!";
        _date = "24th November 1994";
        _time = "3:00 pm";
        _type = "Outdoor event";
    }

    public void StandardOutdoor()
    {
        DisplayStandard();
        Console.WriteLine();
        address3.Display();
    }

    public void FullOutdoor()
    {
        DisplayFull();
        Console.WriteLine();
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine();
        address3.Display();
    }

    public void ShortOutdoor()
    {
        DisplayShort();
    }
}