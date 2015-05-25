/*
Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;
using System.Linq;
class FindWorkdays
{

    static DateTime[] holidays = { new DateTime(2014, 12, 24), 
                                   new DateTime(2014, 12, 25), 
                                   new DateTime(2014, 12, 26),
                                   new DateTime(2014, 12, 30), 
                                   new DateTime(2014, 12, 31), 
                                   new DateTime(2014, 01, 01),
                                   new DateTime(2015, 01, 01),
                                   new DateTime(2015, 03, 03),};

    static DateTime startDate = new DateTime(2015, 03, 31);
    static DateTime endDate = DateTime.Now;


    static void Main()
    {
        int cnt = CalculateWorkDays();
        Console.WriteLine("Workdays = {0}", cnt);

    }

    static int CalculateWorkDays() 
    {
        int cnt = 0;

        if (endDate.Date > startDate.Date)
        {
            DateTime day = startDate.Date;
            while (day <= endDate.Date)
            {
                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(day))
                {
                    cnt++;
                }
                day = day.AddDays(1);
            }
        }
        else 
        {
            DateTime day = endDate.Date;
            while (day <= startDate.Date)
            {
                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(day))
                {
                    cnt++;
                }
                day = day.AddDays(1);
            }
        }

        return cnt;
    }
}

