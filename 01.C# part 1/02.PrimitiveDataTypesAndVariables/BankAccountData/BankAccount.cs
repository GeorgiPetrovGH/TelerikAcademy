/*
Problem 11. Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN,
3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        ulong balance = 1000000;
        ulong firstCardnumber = 1111111111;
        ulong secondCardNumber = 2222222222;
        ulong thirdCardNumber = 3333333333;

        Console.WriteLine("First Name  : " + firstName);
        Console.WriteLine("Middle Name : " + middleName);
        Console.WriteLine("Last Name   : " + lastName);
        Console.WriteLine("Balance     : " + balance);
        Console.WriteLine("First Card  : " + firstCardnumber);
        Console.WriteLine("Second Card : " + secondCardNumber);
        Console.WriteLine("Third Card  : " + thirdCardNumber);
    }
}

