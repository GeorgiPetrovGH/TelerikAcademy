/*
Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime. 
*/

using System;
class CheckLeapYear
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Is {0} a leap year: {1}", date.Year, IsLeapYear(date.Year));
        date = new DateTime(1986, 12, 20);
        Console.WriteLine("Is {0} a leap year: {1}", date.Year, IsLeapYear(date.Year));
        date = new DateTime(1996, 12, 20);
        Console.WriteLine("Is {0} a leap year: {1}", date.Year, IsLeapYear(date.Year));
        Console.WriteLine("Is {0} a leap year: {1}", date.Year, DateTime.IsLeapYear(date.Year)); 
    }

    static bool IsLeapYear(int year)
    {
        if ((year % 4) == 0)
        {
            if ((year % 100) == 0)
            {
                if ((year % 400) == 0)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }
        return false;
    }
}

