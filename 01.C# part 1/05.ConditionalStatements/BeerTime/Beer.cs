﻿/*
Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
Note: You may need to learn how to parse dates and times.
 */

using System;
using System.Globalization;
class Beer
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime time;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        Console.Write("Enter time: ");
        string timeString = Console.ReadLine();

        if (DateTime.TryParseExact(timeString, "h:mm tt", enUS,
                                    DateTimeStyles.None, out time))
        {
            if (time > startTime || time < endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

