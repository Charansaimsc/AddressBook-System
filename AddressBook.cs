using System;
using System.Collections.Generic;

public class AddressBook
{
    public List<Contact> Persons = new List<Contact>();

    // UC-5Add Contact
    public void AddContact(Contact contact)
    {
        Persons.Add(contact);
        Console.WriteLine("Contact added successfully.");
    }

    // UC-3Edit Contact by First Name
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

    // UC-4Delete Contact by First Name
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

    // Display All Contacts
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
