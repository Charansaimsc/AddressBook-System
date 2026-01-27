using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        AddressBook addressBook = new AddressBook();
        Contact contact = new Contact();

        Console.Write("Enter First Name: ");
        contact.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        contact.LastName = Console.ReadLine();

        Console.Write("Enter Address: ");
        contact.Address = Console.ReadLine();

        Console.Write("Enter City: ");
        contact.City = Console.ReadLine();

        Console.Write("Enter State: ");
        contact.State = Console.ReadLine();

        Console.Write("Enter Zip: ");
        contact.Zip = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        contact.PhoneNumber = Console.ReadLine();

        Console.Write("Enter Email: ");
        contact.Email = Console.ReadLine();

        addressBook.AddContact(contact);

        Console.WriteLine("\n--- Original Contact ---");
        addressBook.Person.Display();

        Console.Write("\nEnter First Name to Edit: ");
        string nameToEdit = Console.ReadLine();

        addressBook.EditContact(nameToEdit);

        Console.WriteLine("\n Updated Contact");
        addressBook.Person.Display();
    }
}
