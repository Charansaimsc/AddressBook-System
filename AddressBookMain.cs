using System;
namespace AddressBooks
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("................Welcome to AddressBook..........");
            // Contact c = new Contact();
            // c.FirstName = "sai";
            // c.PhoneNumber = "6396396390";
            // c.LastName = "charan";
            // c.Zip = "281406";
            // c.Address = "GLA UNIVERSITY,Mathura";
            // c.City = "Mathura";
            // c.Email = "sai909@gmail.com";
            // c.State = "Mathura";
            // c.Display();


            // uc-02
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

            addressBook.AddPerson(contact);

            // Display using Contact method
            addressBook.Person.Display();

        }
    }
}