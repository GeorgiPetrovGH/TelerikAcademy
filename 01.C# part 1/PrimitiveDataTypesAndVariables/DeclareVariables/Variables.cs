/*
Problem 1. Declare Variables
Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */

using System;

class Variables
{
    static void Main()
    {
        sbyte smallNumber01 = -115;
        byte smallNumber02 = 97;
        short mediumNumber01 = -10000;
        ushort mediumNumber02 = 52130;
        int number = 4825932;
        Console.WriteLine("This is a signed 8-bit: " + smallNumber01);
        Console.WriteLine("This is an unsigned 8-bit: " + smallNumber02);
        Console.WriteLine("This is a signed 16-bit: " + mediumNumber01);
        Console.WriteLine("This is an unsigned 16-bit: " + mediumNumber01);
        Console.WriteLine("This is a signed 32-bit: " + number);
    }
}

