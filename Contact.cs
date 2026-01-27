using System;

public class Contact
{
    // UC-1: Contact properties
    public string FirstName;
    public string LastName;
    public string Address;
    public string City;
    public string State;
    public string Zip;
    public string PhoneNumber;
    public string Email;

    public void Display()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Name   : {FirstName} {LastName}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"City   : {City}");
        Console.WriteLine($"State  : {State}");
        Console.WriteLine($"Zip    : {Zip}");
        Console.WriteLine($"Phone  : {PhoneNumber}");
        Console.WriteLine($"Email  : {Email}");
    }
}
