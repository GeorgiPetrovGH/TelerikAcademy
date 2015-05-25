/*
Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
 */

using System;
class Numbers
{
    static void Main()
    {
        Console.Write("Enter Integer Number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 1)
        {
            Console.WriteLine("Invalid input.");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

    }
}

