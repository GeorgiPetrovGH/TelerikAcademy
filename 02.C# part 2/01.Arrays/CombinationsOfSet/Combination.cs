/*
Problem 21.* Combinations of set

Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
*/
using System;

class Combination
{
    static int n = 5;
    static int k = 2;
    static void Main()
    {
        int[] array = new int[k];
        bool[] used = new bool[n];
        comb(array, used, 0);
    }

    static void print(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write("{0} ", element + 1);
        }
        Console.WriteLine();
    }
    static void comb(int[] arr, bool[] used, int index)
    {
        if (index == k)
        {
            print(arr);
        }
        else
        {
            for (int i = 0; i <= n - k + index; i++)
            {
                if (!used[i])
                { 
                    arr[index] = i;
                    used[i] = true;
                    comb(arr, used, index + 1);
                    used[i] = false;
                }                
            }
        }
    }
}

