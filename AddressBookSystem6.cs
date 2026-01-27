using System;
using System.Collections.Generic;

public class AddressBookSystem
{
    // UC-6: Multiple AddressBooks
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
            return AddressBooks[name];

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

    // UC-8: Search by City
  
    public void SearchPersonByCity(string city)
    {
        bool found = false;

        foreach (KeyValuePair<string, AddressBook> entry in AddressBooks)
        {
            foreach (Contact person in entry.Value.Persons)
            {
                if (person.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    if (!found)
                    {
                        Console.WriteLine($"\nPersons in City: {city}");
                        found = true;
                    }

                    Console.WriteLine($"AddressBook: {entry.Key}");
                    person.Display();
                }
            }
        }

        if (!found)
        {
            Console.WriteLine($"No persons found in city: {city}");
        }
    }

  
    // UC-8: Search by State
  
    public void SearchPersonByState(string state)
    {
        bool found = false;

        foreach (KeyValuePair<string, AddressBook> entry in AddressBooks)
        {
            foreach (Contact person in entry.Value.Persons)
            {
                if (person.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    if (!found)
                    {
                        Console.WriteLine($"\nPersons in State: {state}");
                        found = true;
                    }

                    Console.WriteLine($"AddressBook: {entry.Key}");
                    person.Display();
                }
            }
        }

        if (!found)
        {
            Console.WriteLine($"No persons found in state: {state}");
        }
    }
}
