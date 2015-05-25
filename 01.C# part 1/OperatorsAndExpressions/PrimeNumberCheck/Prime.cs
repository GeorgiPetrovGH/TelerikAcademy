/*
Problem 8. Prime Number Check
Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
*/

using System;
class Prime
{
    static bool primeCheck(int x) 
    {
        if (x == 0 || x == 1) 
        {
            return false;
        }
        else
        {
            int k = (int)Math.Sqrt((double) x);
            for (int i = 2; i <= k; i++)
            {
                if (x % i == 0) 
                {
                    return false;
                } 
            }
            return true;
        }
    }
    static void Main()
    {
        Console.Write("Enter Integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Number is Negative.");
        }
        else 
        {
            if (primeCheck(number)) 
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("fasle");
            }
        }
    }
}