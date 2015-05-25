/*
Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;
class DateCanada
{
    static void Main()
    {
        string text = "10.10.2015 more text another text another date 10.10.2014 more stuff more text more date 10.10.2013 more stuff";
        string patern = @"([0-9][0-9].[0-9][0-9].[0-9][0-9][0-9][0-9])";
        Match match = Regex.Match(text, patern);
        while (match.Success)
        {
            string stringDate = match.ToString();
            DateTime date;
            if (DateTime.TryParseExact(stringDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
            match = match.NextMatch();
        }
    }
}

