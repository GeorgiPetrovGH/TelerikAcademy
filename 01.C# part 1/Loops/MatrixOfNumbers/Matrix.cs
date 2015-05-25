/*
Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
and prints a matrix like in the examples below. Use two nested loops.
 */

using System;
class Matrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 20)
        {
            Console.WriteLine("Invalid input.");
        }
        else 
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= i + n; j++)
                {
                    Console.Write("{0} ", Convert.ToString(j).PadLeft(2));
                }
                Console.WriteLine();
            }
        }
        
    }
}

