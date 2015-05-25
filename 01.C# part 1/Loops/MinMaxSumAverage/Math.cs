/*
Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers 
(displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 */

using System;
class Math
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int maxNumber = int.MinValue, minNumber = int.MaxValue, sum = 0, average = 0, count = 0;
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > maxNumber) 
            {
                maxNumber = number;
            }
            if (number < minNumber) 
            {
                minNumber = number;
            }
            sum += number;
            count++;
        }
        Console.WriteLine("Max Number: {0}", maxNumber);
        Console.WriteLine("Min Number: {0}", minNumber);
        Console.WriteLine("Sum       : {0}", sum);
        Console.WriteLine("Average   : {0:F2}", (double) sum / count);
    }
}

