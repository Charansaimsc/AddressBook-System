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


    
    // UC-7: Override Equals to identify duplicate contact
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Contact))
            return false;

        Contact other = (Contact)obj;

        return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
            && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
    }

    // UC-7: Must override when Equals is overridden
    public override int GetHashCode()
    {
        return (FirstName + LastName).ToLower().GetHashCode();
    }

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
