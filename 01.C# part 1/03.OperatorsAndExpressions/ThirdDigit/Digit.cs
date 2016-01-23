/*
Problem 5. Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/

using System;
class Digit
{
    static void Main()
    {
        Console.Write("Enter Integer Number: ");
        int number = int.Parse(Console.ReadLine());
        int digit = number / 100;
        digit = digit % 10;
        Console.WriteLine("Third digit is 7?");
        if (digit == 7)
        {
            Console.WriteLine("true");
        }
        else 
        {
            Console.WriteLine("false");
        }
    }
}

