using System;

public class Customer
{
    private string _name;
    Address address = new Address();

    public Customer(){}

    public Customer(string name)
    {
        _name = name;
    }
    // im supposed to do something with address...i think call the address method in another method?

    public void DisplayCustomer()
    {
        Console.WriteLine("${_name}");
        address.DisplayAddress();

        
    }

    public void CustomerCountry()
    {
        address.ComputeCountry();
    }
}