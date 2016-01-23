/*
Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 */

using System;
class RandomNUmbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {            
            Console.Write("{0} ", rand.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}

