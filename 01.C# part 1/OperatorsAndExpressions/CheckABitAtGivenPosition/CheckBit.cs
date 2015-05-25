/*
Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p 
(counting from 0, starting from the right) in given integer number n, has value of 1.
*/

using System;
class CheckBit
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter Bit Position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine(bit);
        if (bit == 1) Console.WriteLine(true);
        else Console.WriteLine(false);       
    }
}

