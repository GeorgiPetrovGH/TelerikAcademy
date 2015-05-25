/*
Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
*/
using System;

class MaxSum
{
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
        int maxSum = int.MinValue;
        int currentSum = array[0];
        int currentPosition = 0;
        int start = 0, end = 0;

        for (int i = 1; i < array.Length; i++)
        {
            currentSum += array[i];
            if (array[i] > currentSum) 
            {
                currentSum = array[i];
                currentPosition = i;
            }

            if (maxSum < currentSum) 
            {
                maxSum = currentSum;
                start = currentPosition;
                end = i;
            }
        }

        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}

