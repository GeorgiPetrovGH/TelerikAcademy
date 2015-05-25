/*
Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/
using System;

class Prime
{
    static void Main()
    {
        int n = 10000;
        bool[] array = new bool[n+1];       
        
        int k = (int) Math.Sqrt(n);
        for (int i = 2; i <= k; i++)
        {
            if (array[i] == false) 
            {
                for (int j = i * i; j <= n; j += i)
                {
                    array[j] = true;
                }
            }
        }
        
        for (int i = 0; i <= n; i++)
        {
            if (array[i] == false) 
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}

