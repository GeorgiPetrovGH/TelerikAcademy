/*
Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */

using System;
class DecinalToBinary
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        string binaryNumber = "";
        while (number > 0) 
        {
            long digit = number % 2;
            binaryNumber += digit;
            number /= 2;
        }
        
        char[] array = binaryNumber.ToCharArray();
        Array.Reverse(array);        
        string result = new String(array);        
        Console.WriteLine(result);
    }
}

