using System;

public class Customer
{
    private string _name;
    private Address _address = new Address();

    public Address Address{get{return _address;}}

    public Customer(){}

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    // im supposed to do something with address...i think call the address method in another method?

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_name}");
        _address.DisplayAddress();

        
    }

    public void CustomerCountry()
    {
        _address.ComputeCountry();
    }
}