/*
Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */

using System;
class ShortToBin
{
    static void Main()
    {
        short number = 123;
        Console.WriteLine(GetBinary(number));
    }
    static string GetBinary(short s)
    {
        string result = String.Empty;
        for (int i = 0; i < 16; i++)
        {
            result = (s >> i & 1) + result;
        }
        return result;
    }
}


