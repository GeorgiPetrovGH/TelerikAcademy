/*
Problem 19.* Permutations of set

Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
*/
using System;

class Permutation
{
    static void Main()
    {
        int n = 4;
        int[] array = new int[n];
        bool[] used = new bool[n];
        perm(array, used, 0);
    }

    static void print(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write("{0} ", element + 1);
        }
        Console.WriteLine();
    }
    static void perm(int[] arr, bool[] used, int index)
    {
        if (index == arr.Length)
        {
            print(arr);
            return;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (!used[i])
            {
                arr[index] = i;
                used[i] = true;
                perm(arr, used, index + 1);
                used[i] = false;
            }
        }
    }
}

