/*
Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/

using System;
class SortArray
{
    static int[] array = { 1, -2, 7, 5, 3, 2, 6, 3, -2, 10, -1, 1, 5, 9, 8, 0 };
    static void Main()
    {
        
        PrintArray();
        SortArr(true);
        PrintArray();
        SortArr(false);
        PrintArray();
    }

    static void PrintArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void Swap(int x, int y)
    {
        int temp = array[x];
        array[x] = array[y];
        array[y] = temp;
    }

    static int GetIndex(int firstIndex, int secondIndex, bool ascending)
    {
        int maxIndex = 0;
        int maxNumber = int.MinValue;

        int minIndex = 0;
        int minNumber = int.MaxValue;

        if (ascending)
        {
            for (int i = firstIndex; i <= secondIndex; i++)
            {
                if (array[i] >= maxNumber)
                {
                    maxNumber = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        else
        {
            for (int i = firstIndex; i <= secondIndex; i++)
            {
                if (array[i] <= minNumber)
                {
                    minNumber = array[i];
                    minIndex = i; 
                }
            }
            return minIndex;
        }

    }

    static void SortArr(bool ascending) 
    {
        int len = array.Length;
        
        if(ascending)
        {
            for (int i = len - 1; i >= 0; i--)
            {
                Swap(i, GetIndex(0, i, true));
            }
        }
        else 
        {
            for (int i = len - 1; i >= 0; i--)
            {
                Swap(i, GetIndex(0, i, false));
            }
        }
    }
}

