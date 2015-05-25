/*
Problem 20.* Variations of set

Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
*/
using System;

class Variation
{
    static void Main()
    {
        int n = 3;
        int k = 3;
        int[] array = new int[k];        
        var(array,0 , n);
    }

    static void print(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write("{0} ", element + 1);
        }
        Console.WriteLine();
    }
    static void var(int[] arr, int index, int elements)
    {
        if (index == arr.Length)
        {
            print(arr);           
        }
        else
        {
            for (int i = 0; i < elements; i++)
            {
                arr[index] = i;
                var(arr, index + 1, elements);
            }
        }
    }
}

