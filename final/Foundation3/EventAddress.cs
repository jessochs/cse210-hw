using System;

public class EventAddress
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;


    public EventAddress(string street, string city, string state, string zipcode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }


    public void Display()
    {
        Console.WriteLine(_street);
        Console.WriteLine($"{_city}, {_state}");
        Console.WriteLine(_zipcode);
    }
}