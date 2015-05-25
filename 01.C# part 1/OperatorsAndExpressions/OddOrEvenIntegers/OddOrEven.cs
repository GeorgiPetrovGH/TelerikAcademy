/*
Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even.
*/

using System;
class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter Integer Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number + " is odd?");
        if (number % 2 == 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
        
    }
}
