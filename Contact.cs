using System;
namespace AddressBook
{
    public class Contact
    {
        public String FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string Email;

        public void Display()
        {
            Console.WriteLine($"Person Name: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"State: {State}");
            Console.WriteLine($"Zip: {Zip}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("--------------------");
        }
    }
}