/*
Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
 */

using System;
class DecimalBinary
{
    static void Main()
    {
        int decNumber = 25;
        Console.WriteLine(FindBinaryNumber(decNumber));
    }

    static int FindBinaryNumber(int x) 
    {
        string result = "";
        while (x > 0) 
        {
            result = x % 2 + result;
            x /= 2;
        }        
        return int.Parse(result);
    }
}

