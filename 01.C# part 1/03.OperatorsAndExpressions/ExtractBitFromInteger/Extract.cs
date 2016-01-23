/*
Problem 12. Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p.
*/

using System;
class Extract
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

    }
}
