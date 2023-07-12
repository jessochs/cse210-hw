using System;

public class Reception : Event
{
    private string _email = "mollyweasley@hogsmeade.com";
    private EventAddress address2 = new EventAddress("Third house by the field", "The Burrow", "Chester", "00004");

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
        Console.WriteLine();
        address2.Display();
    }

    public void FullReception()
    {
        DisplayFull();
        Console.WriteLine();
        Console.WriteLine($"Please RSVP at {_email} or via owl");
        Console.WriteLine();
        address2.Display();

    }

    public void ShortReception()
    {
        DisplayShort();
        
    }

}