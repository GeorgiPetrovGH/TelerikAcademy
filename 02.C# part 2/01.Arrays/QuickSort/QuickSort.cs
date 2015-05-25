/*
Problem 14. Quick sort

Write a program that sorts an array of integers using the Quick sort algorithm.
*/
using System;

class QuickSort
{
    static void Main()
    {
        int[] array = { 25, 17, 9, 3, 67, 90, 1, 15, 7, 44, 18, 6, 155, 75, 12 };
        int left = 0;
        int right = array.Length - 1;

        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();

        QuickSortCode(array, left, right);

        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }

    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;

            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSortCode(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
                QuickSortCode(arr, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSortCode(arr, pivot + 1, right);
        }
    }
}

