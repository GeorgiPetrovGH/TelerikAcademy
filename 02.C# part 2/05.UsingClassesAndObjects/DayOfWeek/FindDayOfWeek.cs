/*
Problem 3. Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.
*/

using System;
class FindDayOfWeek
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Today is {0}", date.DayOfWeek);
        date = new DateTime(1986, 10, 20);
        Console.WriteLine("What day was {0} of {1} {2}? It was {3}.", date.Day, date.ToString("MMMM"), date.Year, date.DayOfWeek);
    }      
}

