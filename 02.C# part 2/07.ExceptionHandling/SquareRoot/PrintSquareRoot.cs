/*
Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 */

using System;
class PrintSquareRoot
{
    static void Main()
    {
        SquareRoot();
    }
    static void SquareRoot() 
    {
        try
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new FormatException();
            }
            double result = Math.Sqrt(number);
            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("This is not integer.");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}

