/*
Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/

using System;
class CountNumbers
{

    
    static void Main()
    {
        int[] array = { 1, 0, 7, 5, 3, 2, 1, 1, 5, 9, 8, 0, 3, 2, 5, 7, 3, 1, 2, 3, 1, 2, 6, 1, 9, 1, 0, 6, 7, 9, 0, 4, 3, 5 };
        int number = 1;
        PrintArray(array);
        Console.WriteLine("Number {0} is found {1} times in the array.", number, CountNumber(array, number));       
        
    }

    static int CountNumber(int[] array, int number) 
    {
        int count = 0;
        foreach (int item in array)
        {
            if (item == number) 
            {
                count++;
            }
        }
        return count;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}

