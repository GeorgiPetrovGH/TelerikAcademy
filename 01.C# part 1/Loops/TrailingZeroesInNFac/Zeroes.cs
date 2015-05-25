/*
Problem 18.* Trailing Zeroes in N!

Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
 */

using System;
using System.Numerics;
class Zeroes
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger fac = 1;
        for (int i = 1; i <= n; i++)
        {
            fac *= i;
        }
        int count = 0;
        while (fac % 10 == 0) 
        {
            count++;
            fac /= 10;
        }
        Console.WriteLine(count);
    }
}

