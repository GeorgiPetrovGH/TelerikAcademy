/*
Problem 9. Print a Sequence
Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/

using System;
class Sequence
{
    static void Main()
    {
        Console.Write(2);
        for (int i = 3; i < 13; i++)
        {
            Console.Write(", ");
            if (i % 2 != 0)
            {
                Console.Write("-");
            }
            Console.Write(i);
        }
        Console.WriteLine();
    }
}

