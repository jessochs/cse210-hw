using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;
    private string _country;

    public Address(){}

    public Address(string street, string city, string state, string country, string zipcode)
    {
        _street = street;
        _city = city;
        _zipcode = zipcode;
        _state = state;
        _country = country;

    }

    public bool ComputeCountry()
    {

        if (_country == "USA")
        {
           return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}\n {_city}, {_state} {_zipcode}\n{_country}");
    }
}