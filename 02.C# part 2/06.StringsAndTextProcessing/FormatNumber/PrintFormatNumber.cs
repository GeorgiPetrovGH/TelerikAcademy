/*
Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
*/

using System;
class PrintFormatNumber
{
    static void Main()
    {
        int number = 123;
        string result = string.Format("{0,15:D}\n{0,15:X4}\n{0,15:P0}\n{0,15:E}", number);
        Console.WriteLine(result);
    }
}

