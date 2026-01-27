using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book ");

        AddressBookSystem addressBookSystem = new AddressBookSystem();

        Console.Write("Enter Address Book Name: ");
        string addressBookName = Console.ReadLine();

        addressBookSystem.AddAddressBook(addressBookName);

        AddressBook addressBook = addressBookSystem.GetAddressBook(addressBookName);
        if (addressBook == null)
            return;

        string choice;

        // UC-5: Add multiple contacts
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

            Console.Write("Do you want to add another contact? (yes/no): ");
            choice = Console.ReadLine();

        } while (choice.Equals("yes", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("\n--- All Contacts ---");
        addressBook.DisplayAll();

        // UC-3
        Console.Write("\nEnter First Name to Edit: ");
        string editName = Console.ReadLine();
        addressBook.EditContact(editName);

        Console.WriteLine("\n--- After Edit ---");
        addressBook.DisplayAll();

        // UC-4
        Console.Write("\nEnter First Name to Delete: ");
        string deleteName = Console.ReadLine();
        addressBook.DeleteContact(deleteName);

        Console.WriteLine("\n--- After Delete ---");
        addressBook.DisplayAll();


          // UC-8: Search by City
        Console.Write("\nEnter City to search: ");
        string city = Console.ReadLine();
        addressBookSystem.SearchPersonByCity(city);

        // UC-8: Search by State
        Console.Write("\nEnter State to search: ");
        string state = Console.ReadLine();
        addressBookSystem.SearchPersonByState(state);
    }
}
