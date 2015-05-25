/*
Problem 16.* Subset with sum S

We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.
*/
using System;

class SubsetWithSum
{
    static int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
    static int S = 14;
    static void findSum(int[] array, int sum, int S, int index)
    {
        int tempSum = sum + array[index];
        int tempIndex = index;
        if (index < array.Length)
        {
            if (tempSum == S)
            {
                Console.WriteLine("Yes");
                return;
            }
            else if (tempSum < S)
            {
                findSum(array, tempSum, S, tempIndex++);
            }
            else
            {
                findSum(array, 0, S, index++);
            }
        }
        else 
        {
            Console.WriteLine("No");
            return;
        }

    }
    static void Main()
    {        
        findSum(array, 0, S, 0);
    }
}

