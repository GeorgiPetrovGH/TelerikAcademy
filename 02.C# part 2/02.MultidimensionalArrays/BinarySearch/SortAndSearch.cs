/*
Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, 
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K
*/

using System;
class SortAndSearch
{
    static void Main()
    {
        int[] array = { 20, -8, 15, -25, 16, 45, 9, 23, 23, 0, 6, 32, 14, 41 };
        int k = 25;
        bubbleSort(array);
        printArray(array);
        
        if (k <= array[array.Length - 1] && k >= array[0]) 
        {
            for (int i = k; i >= 0; i--)
            {
                int found = Array.BinarySearch(array,i);
                if (found > 0) 
                {
                    Console.WriteLine("The largest number <= {0} is: {1}", k, array[found]);
                    break;
                }
            }
        }

    }

    static void printArray(int[] array) 
    {
        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
    
    static void bubbleSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
		{
            for (int j = 0; j < array.Length -1; j++)
            {
                if (array[j] > array[j + 1]) 
                {
                    swap(array, j, j+1);
                }
            } 
		}
    }
    
    static void swap(int[] arr, int x, int y)
    {
        int temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
    }
}

