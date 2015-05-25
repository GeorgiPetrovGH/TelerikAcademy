/*
Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
*/

using System;
class CalculateDays
{
    static void Main()
    {
        string firstDate = "27.02.2006";
        string secondDate = "3.03.2006";
        DateTime date01 = ReturnDate(firstDate);
        DateTime date02 = ReturnDate(secondDate);
        Console.WriteLine("{0} days.", (date02 - date01).TotalDays < 0 ? (date01 - date02).TotalDays : (date02 - date01).TotalDays);
    }

    static DateTime ReturnDate(string s) 
    {
        int day = int.Parse(s.Substring(0, s.IndexOf('.', 0)));
        int index = s.IndexOf('.', 0);
        int month = int.Parse(s.Substring(index + 1, 2));
        int index1 = s.IndexOf('.', index + 1);
        int year = int.Parse(s.Substring(index1 + 1, 4));
        DateTime result = new DateTime(year, month, day);
        return result;
    }
}

