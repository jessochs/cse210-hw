using System;

public class Outdoor : Event 
{
    private string _weather = "Partly cloudy";

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
    }

    public void FullOutdoor()
    {
        DisplayFull();
        Console.WriteLine();
        Console.WriteLine($"Weather: {_weather}");
    }

    public void ShortOutdoor()
    {
        DisplayShort();
    }
}