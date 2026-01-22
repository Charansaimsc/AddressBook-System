using System;
namespace AddressBook
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("................Welcome to AddressBook..........");
            Contact c = new Contact();
            c.FirstName = "sai";
            c.PhoneNumber = "6396396390";
            c.LastName = "charan";
            c.Zip = "281406";
            c.Address = "GLA UNIVERSITY,Mathura";
            c.City = "Mathura";
            c.Email = "sai909@gmail.com";
            c.State = "Mathura";
            c.Display();
        }
    }
} 