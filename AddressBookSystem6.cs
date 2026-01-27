using System;
using System.Collections.Generic;

public class AddressBookSystem
{
    // UC-6: Multiple AddressBooks in the system
    public Dictionary<string, AddressBook> AddressBooks =
        new Dictionary<string, AddressBook>();

    public void AddAddressBook(string name)
    {
        if (AddressBooks.ContainsKey(name))
        {
            Console.WriteLine("Address Book already exists.");
            return;
        }

        AddressBooks.Add(name, new AddressBook());
        Console.WriteLine($"Address Book '{name}' created successfully.");
    }

    public AddressBook GetAddressBook(string name)
    {
        if (AddressBooks.ContainsKey(name))
        {
            return AddressBooks[name];
        }

        Console.WriteLine("Address Book not found.");
        return null;
    }

    public void DisplayAllAddressBooks()
    {
        Console.WriteLine("Available Address Books:");
        foreach (string name in AddressBooks.Keys)
        {
            Console.WriteLine("- " + name);
        }
    }
}
