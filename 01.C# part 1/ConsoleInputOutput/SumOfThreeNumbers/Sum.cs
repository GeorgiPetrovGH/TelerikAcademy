/*
Problem 1. Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum.
 */

using System;
class Sum
{
    static void Main()
    {
        Console.Write("Enter a Real Number: ");
        double number01 = double.Parse(Console.ReadLine());
        Console.Write("Enter a Real Number: ");
        double number02 = double.Parse(Console.ReadLine());
        Console.Write("Enter a Real Number: ");
        double number03 = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the three numbers is: {0}", number01 + number02 + number03);
    }
}

