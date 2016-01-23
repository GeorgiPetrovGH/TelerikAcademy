/*
Problem 16. Decimal to Hexadecimal Number

Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality
 */

using System;
class DecinalToHex
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        string hexNumber = "";
        while (number > 0)
        {
            long digit = number % 16;

            switch (digit)
            {
                case 10: hexNumber += "A"; break;
                case 11: hexNumber += "B"; break;
                case 12: hexNumber += "C"; break;
                case 13: hexNumber += "D"; break;
                case 14: hexNumber += "E"; break;
                case 15: hexNumber += "F"; break;
                default: hexNumber += digit; break;
            }            
            number /= 16;
        }

        char[] array = hexNumber.ToCharArray();
        Array.Reverse(array);
        string result = new String(array);
        Console.WriteLine(result);
    }
}

