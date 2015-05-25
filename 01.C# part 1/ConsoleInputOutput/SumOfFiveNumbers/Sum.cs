/*
Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */

using System;
class Sum
{
    static void Main()
    {
        string[] userINput = Console.ReadLine().Split();
        int a = Convert.ToInt32(userINput[0]);
        int b = Convert.ToInt32(userINput[1]);
        int c = Convert.ToInt32(userINput[2]);
        int d = Convert.ToInt32(userINput[3]);
        int e = Convert.ToInt32(userINput[4]);
        Console.WriteLine(a + b + c + d + e);
    }
}

