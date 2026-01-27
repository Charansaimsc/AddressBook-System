using System;

public class AddressBook
{
    public Contact Person;

    public void AddContact(Contact contact)
    {
        Person = contact;
    }

    public void EditContact(string firstName)
    {
        if (Person == null)
        {
            Console.WriteLine("No contact found.");
            return;
        }

        if (Person.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Contact found. Enter new details.");

            Console.Write("Enter New Address: ");
            Person.Address = Console.ReadLine();

            Console.Write("Enter New City: ");
            Person.City = Console.ReadLine();

            Console.Write("Enter New State: ");
            Person.State = Console.ReadLine();

            Console.Write("Enter New Zip: ");
            Person.Zip = Console.ReadLine();

            Console.Write("Enter New Phone Number: ");
            Person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter New Email: ");
            Person.Email = Console.ReadLine();

            Console.WriteLine("Contact updated successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    // UC-4: Delete Contact
    public void DeleteContact(string firstName)
    {
        if (Person == null)
        {
            Console.WriteLine("No contact to delete.");
            return;
        }

        if (Person.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
        {
            Person = null;
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
