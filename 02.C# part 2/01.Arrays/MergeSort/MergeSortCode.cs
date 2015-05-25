/*
Problem 13.* Merge sort

Write a program that sorts an array of integers using the Merge sort algorithm.
*/
using System;
using System.Collections.Generic;

class MergeSort
{

    static public void DoMerge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;

        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);

        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmp_pos++] = numbers[left++];
            else
                temp[tmp_pos++] = numbers[mid++];
        }

        while (left <= left_end)
            temp[tmp_pos++] = numbers[left++];

        while (mid <= right)
            temp[tmp_pos++] = numbers[mid++];

        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void MergeSortCode(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSortCode(numbers, left, mid);
            MergeSortCode(numbers, (mid + 1), right);

            DoMerge(numbers, left, (mid + 1), right);
        }
    }
        
    
    static void Main()
    {
        int[] array = {25, 17, 9, 3, 67, 90, 1, 15, 7, 44, 18, 6, 155, 75, 12 };
        int left = 0;
        int right = array.Length - 1;

        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
        
        MergeSortCode(array, left, right);
        
        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();

    }
    
}

