/*
Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
 */

using System;
class Problem6
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        
        int facN = 1;
        int facK = 1;

        for (int i = 1; i <= n; i++)
        {
            facN *= i;
            if (k >= i) 
            {
                facK *= i;
            }
        }
        Console.WriteLine("n! / k! = {0}", facN / facK);
    }
}

