﻿/*
Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: 
day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/

using System;
using System.Globalization;
class BulgarianDate
{
    static void Main()
    {
        string getDate = "1.03.2015 21:05:30";
        DateTime date = DateTime.ParseExact(getDate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        Console.WriteLine("{0} {1}", date, date.ToString("dddd", new CultureInfo("bg-BG")));
    }
}

