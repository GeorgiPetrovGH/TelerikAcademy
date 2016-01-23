/*
Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
 */

using System;
using System.Numerics;
class Catalan
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        
        BigInteger fac2N = 1, facN = 1, facN1 = 1;
        
        if (n < 0 || n > 100)
        {
            Console.WriteLine("Invalid input.");
        }
        else
        {
            for (int i = 1; i <= 2*n; i++)
            {
                fac2N *= i;
                if (n + 1 >= i) 
                {
                    facN1 *= i;
                }
                if (n >= i) 
                {
                    facN *= i;
                }
            }

            Console.WriteLine(fac2N /(facN1 * facN));
        }
    }
}

