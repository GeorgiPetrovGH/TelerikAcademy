/*
Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
*/
using System;

class Allocate
{
    static void Main()
    {
        int[] array = new int[20];
        for (int i = 0; i < 19; i++)
			{
			    array[i] = i * 5;
                Console.Write(array[i] + " ");
			}
        Console.WriteLine();
    }
}

