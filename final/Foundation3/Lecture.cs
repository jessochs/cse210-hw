using System;

public class Lecture : Event
{
    private string _speaker = "Professor Snape";
    private string _capacity = "45";


    public Lecture()
    {
        _title = "Protecting Yourself Against the Dark Arts";
        _description = "Come learn more from Professor Snape about the defense against the dark arts";
        _date = "15 October 1991";
        _time = "7:00 pm";
        _type = "lecture";

    }

    // public Lecture(string speaker, string capacity)
    // {
    //     _title = "Protecting Yourself Against the Dark Arts";
    //     _description = "Come learn more from Professor Snape about the defense against the dark arts";
    //     _date = "15 October 1991";
    //     _time = "7:00 pm";
    //     _speaker = "Professor Snape";
    //     _capacity
    // }

    public void StandardLecture()
    {
        DisplayStandard();
    }

    public void FullLecture()
    {
        DisplayFull();
        Console.WriteLine();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        
    }

    public void ShortLecture()
    {
        DisplayShort();
    }
}