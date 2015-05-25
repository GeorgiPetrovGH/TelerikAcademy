/*
Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
*/

using System;
class SumString
{
    static void Main()
    {
        string strInt = "43 68 9 23 318";
        int sum = CalculateSum(strInt);
        Console.WriteLine(sum);
    }

    static int CalculateSum(string x) 
    {
        string[] array = x.Split(' ');
        int sum = 0;
        foreach (var item in array)
        {
            sum += int.Parse(item);
        }
        return sum;
    }
}

