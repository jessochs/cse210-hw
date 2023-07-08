using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;
    private string _country;

    public Address(){}

    public Address(string street, string city, string zipcode, string state, string country)
    {
        _street = street;
        _city = city;
        _zipcode = zipcode;
        _state = state;
        _country = country;

    }

    public string ComputeCountry()
    {
        string shippingCountry;

        if (_country == "USA")
        {
           shippingCountry = "USA";
        }
        else
        {
            shippingCountry ="Other";
        }

        return shippingCountry;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}{Environment.NewLine}{_city}, {_state} {_zipcode}{Environment.NewLine}{_country}");
    }
}