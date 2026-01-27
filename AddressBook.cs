using System;
using System.Collections.Generic;

public class AddressBook
{
    // UC-5: Multiple contacts in one AddressBook
    public List<Contact> Persons = new List<Contact>();

    // UC-2: Add contact
    public void AddContact(Contact contact)
    {
         // UC-7 Prevent duplicate contact
        if (Persons.Contains(contact))
        {
            Console.WriteLine("Duplicate contact found. Entry not added.");
            return;
        }

        Persons.Add(contact);
        Console.WriteLine("Contact added successfully.");
    }

    // UC-3: Edit contact using first name
    public void EditContact(string firstName)
    {
        bool found = false;

        foreach (Contact person in Persons)
        {
            if (person.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Contact found. Enter new details.");

                Console.Write("Enter New Address: ");
                person.Address = Console.ReadLine();

                Console.Write("Enter New City: ");
                person.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                person.State = Console.ReadLine();

                Console.Write("Enter New Zip: ");
                person.Zip = Console.ReadLine();

                Console.Write("Enter New Phone Number: ");
                person.PhoneNumber = Console.ReadLine();

                Console.Write("Enter New Email: ");
                person.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Contact not found.");
        }
    }

    // UC-4: Delete contact using first name
    public void DeleteContact(string firstName)
    {
        Contact contactToDelete = null;

        foreach (Contact person in Persons)
        {
            if (person.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
            {
                contactToDelete = person;
                break;
            }
        }

        if (contactToDelete != null)
        {
            Persons.Remove(contactToDelete);
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }


    // UC-11: Sort by Person Name

    public void SortByName()
    {
        Persons.Sort((c1, c2) =>
            string.Compare(
                c1.FirstName + c1.LastName,
                c2.FirstName + c2.LastName,
                StringComparison.OrdinalIgnoreCase));
    }


    // UC-12: Sort by City
    public void SortByCity()
    {
        Persons.Sort((c1, c2) =>
            string.Compare(c1.City, c2.City, StringComparison.OrdinalIgnoreCase));
    }

    // UC-12: Sort by State
    public void SortByState()
    {
        Persons.Sort((c1, c2) =>
            string.Compare(c1.State, c2.State, StringComparison.OrdinalIgnoreCase));
    }

    // UC-12: Sort by Zip
    public void SortByZip()
    {
        Persons.Sort((c1, c2) =>
            string.Compare(c1.Zip, c2.Zip, StringComparison.OrdinalIgnoreCase));
    }
    // UC-5: Display all contacts
    public void DisplayAll()
    {
        if (Persons.Count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        foreach (Contact person in Persons)
        {
            person.Display();
        }
    }
}
