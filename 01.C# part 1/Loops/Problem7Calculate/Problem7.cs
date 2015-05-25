/*
Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
 */

using System;
class Problem7
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int facN = 1;
        int facK = 1;
        int facNK = 1;

        for (int i = 1; i <= n; i++)
        {
            facN *= i;
            if (k >= i)
            {
                facK *= i;
            }
        }

        for (int i = 1; i <= n - k; i++)
			{
			    facNK *= i;
			}
        
        Console.WriteLine("n! / (k! * (n-k)!) = {0}", facN / (facK * facNK));
    }
}

