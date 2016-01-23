/*
Problem 2. Print Company Information
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;
class Company
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter address: ");
        string address = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        string age = Console.ReadLine();
        Console.Write("Enter manager's phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("Company  :  " + companyName);
        Console.WriteLine("Address  :  " + address);
        Console.WriteLine("Tel.     :  " + phoneNumber);
        Console.WriteLine("Fax      :  " + faxNumber);
        Console.WriteLine("Web site :  " + webSite);
        Console.WriteLine("Manager  :  {0} {1} (age : {2}, tel. {3})",firstName, lastName, age, managerPhoneNumber);
    }
}

