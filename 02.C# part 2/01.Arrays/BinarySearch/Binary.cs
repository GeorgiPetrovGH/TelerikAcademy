/*
Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/
using System;

class Binary
{
    static void Main()
    {
        int[] array = { 1, 1, 3, 4, 5, 8, 12, 15, 16, 19, 21, 26, 27, 45, 54, 55, 59, 61, 63, 64, 67, 87, 92 };
        int number = 67;

        int left = 0;
        int right = array.Length;
        bool found = false;
       
        while (left <= right) 
        {
            int middle = (left + right) / 2;
            if (array[middle] == number) 
            {
                Console.WriteLine("index of {0} is {1}.", number, middle);
                found = true;
                break;
            }
            if (array[middle] < number) 
            {
                left = middle + 1;
            }
            if (array[middle] > number) 
            {
                right = middle - 1;
            }
        }

        if (!found) 
        {
            Console.WriteLine("No such number.");
        }

    }
}

