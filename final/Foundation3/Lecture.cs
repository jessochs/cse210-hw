using System;

public class Lecture : Event
{
    private string _speaker = "Professor Snape";
    private string _capacity = "45";
    private EventAddress address1 = new EventAddress("Hogwarts", "Unknown", "United Kingdom", "00001");


    public Lecture()
    {
        _title = "Protecting Yourself Against the Dark Arts";
        _description = "Come learn more from Professor Snape about the defense against the dark arts";
        _date = "15 October 1991";
        _time = "7:00 pm";
        _type = "lecture";

        

    }



    public void StandardLecture()
    {
        DisplayStandard();
        Console.WriteLine();
        address1.Display();
    }

    public void FullLecture()
    {
        DisplayFull();
        Console.WriteLine();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine();
        address1.Display();
        
    }

    public void ShortLecture()
    {
        DisplayShort();
        
    }
}