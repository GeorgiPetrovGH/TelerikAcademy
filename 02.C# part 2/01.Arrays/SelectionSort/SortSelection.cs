/*
Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/
using System;

class SortSelection
{
    static void Main()
    {
        int[] array = { 20, -8, 15, -25, 16, 45, 9, 23, 23, 0, 6 };
        int iMin = 0;

        Console.WriteLine("before sort:");
        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
        
        for (int i = 0; i < array.Length; i++)
        {
            iMin = i;
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[iMin] > array[j]) 
                {
                    iMin = j;
                }
            }
            if (iMin != i) 
            { 
                swap(ref array, iMin,i);
            }
        }
        Console.WriteLine("after sort:");
        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }

    static void swap(ref int[] arr, int x, int y)
    {
        int temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
    }
}

