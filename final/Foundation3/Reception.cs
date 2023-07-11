using System;

public class Reception : Event
{
    private string _email = "mollyweasley@hogsmeade.com";

    public Reception()
    {
        _title = "Wedding for Bill and Fleur";
        _description = "Please join us for the magical celebration of two wonderful wizards.";
        _date = "1st August 1997";
        _time = "6:00 pm";
        _type = "Reception";
    }

    public void StandardReception()
    {
        DisplayStandard();
    }

    public void FullReception()
    {
        DisplayFull();
        Console.WriteLine();
        Console.WriteLine($"Please RSVP at {_email} or via owl");

    }

    public void ShortReception()
    {
        DisplayShort();
    }

}