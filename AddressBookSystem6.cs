using System;
using System.Collections.Generic;

public class AddressBookSystem
{
    public Dictionary<string, AddressBook> AddressBooks =
        new Dictionary<string, AddressBook>();

    // UC-6 
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
            Console.WriteLine("- " + name);
    }

    //UC-8 
    public void SearchPersonByCity(string city)
    {
        foreach (var entry in AddressBooks)
        {
            foreach (Contact person in entry.Value.Persons)
            {
                if (person.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"AddressBook: {entry.Key}");
                    person.Display();
                }
            }
        }
    }

    public void SearchPersonByState(string state)
    {
        foreach (var entry in AddressBooks)
        {
            foreach (Contact person in entry.Value.Persons)
            {
                if (person.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"AddressBook: {entry.Key}");
                    person.Display();
                }
            }
        }
    }

   
    // UC-9: View Persons by City
    public Dictionary<string, List<Contact>> ViewPersonsByCity()
    {
        Dictionary<string, List<Contact>> cityDictionary =
            new Dictionary<string, List<Contact>>();

        foreach (var entry in AddressBooks)
        {
            foreach (Contact person in entry.Value.Persons)
            {
                if (!cityDictionary.ContainsKey(person.City))
                {
                    cityDictionary[person.City] = new List<Contact>();
                }

                cityDictionary[person.City].Add(person);
            }
        }

        return cityDictionary;
    }

  
    // UC-9: View Persons by State
   
    public Dictionary<string, List<Contact>> ViewPersonsByState()
    {
        Dictionary<string, List<Contact>> stateDictionary =
            new Dictionary<string, List<Contact>>();

        foreach (var entry in AddressBooks)
        {
            foreach (Contact person in entry.Value.Persons)
            {
                if (!stateDictionary.ContainsKey(person.State))
                {
                    stateDictionary[person.State] = new List<Contact>();
                }

                stateDictionary[person.State].Add(person);
            }
        }

        return stateDictionary;
    }
}
