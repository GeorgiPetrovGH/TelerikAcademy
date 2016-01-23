/*
Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

using System;
class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number,2).PadLeft(16, '0'));

        uint mask = 1 << 3;
        uint numberAndMask = number & mask;
        uint bit = numberAndMask >> 3;
        Console.WriteLine(bit);
    }
}

