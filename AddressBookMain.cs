using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        AddressBook addressBook = new AddressBook();
        string choice;

        // UC-5 Add multiple contacts
        do
        {
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

            Console.Write("\nDo you want to add another contact? (yes/no): ");
            choice = Console.ReadLine();

        } while (choice.Equals("yes", StringComparison.OrdinalIgnoreCase));

        // Display all contacts
        Console.WriteLine("\n--- All Contacts ---");
        addressBook.DisplayAll();

        // UC-3Edit contact
        Console.Write("\nEnter First Name to Edit: ");
        string editName = Console.ReadLine();
        addressBook.EditContact(editName);

        Console.WriteLine("\n--- After Edit ---");
        addressBook.DisplayAll();

        // UC-4 Delete contact
        Console.Write("\nEnter First Name to Delete: ");
        string deleteName = Console.ReadLine();
        addressBook.DeleteContact(deleteName);

        Console.WriteLine("\n--- After Delete ---");
        addressBook.DisplayAll();
    }
}
