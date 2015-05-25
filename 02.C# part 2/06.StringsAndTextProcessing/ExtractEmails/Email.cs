/*
Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Linq;
class Email
{
    static void Main()
    {
        string email = "email@abv.bg more stuff another email email@gmail.com more stuff";
        string[] text = email.Split(' ');
        foreach (var item in text)
        {
            if (item.Contains('@')) 
            {
                Console.WriteLine(item);
            }
        }
    }
}

