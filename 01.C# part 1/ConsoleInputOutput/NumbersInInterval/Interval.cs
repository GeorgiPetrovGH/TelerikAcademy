/*
Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
 */

using System;
class Interval
    {
        static void Main()
        {
            Console.Write("Enter start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end: ");
            int end = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0) count++;
            }

            Console.WriteLine("Numbers in that interval devided by 5 without reminder: {0}", count);
        }
    }

