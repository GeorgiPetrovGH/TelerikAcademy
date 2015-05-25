/*
Problem 8. Isosceles Triangle
Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
*/

using System;

class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string symbol = "\u00A9";        
        Console.WriteLine("   " + symbol);
        Console.WriteLine();
        Console.WriteLine("  " + symbol + " " + symbol);
        Console.WriteLine();
        Console.WriteLine(" " + symbol + "   " + symbol);
        Console.WriteLine();
        Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);
    }
}

