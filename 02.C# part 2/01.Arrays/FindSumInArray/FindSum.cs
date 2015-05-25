/*
Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
*/
using System;

class FindSum
{
    static void Main()
    {
        int[] array = { 5, 3, 1, 4, 2, 5, 8, 3 };
        int S = 19;
        
        int lenght = array.Length;
        bool check = false;

        for (int i = 0; i < lenght; i++)
        {
            int tempSum = 0;
            int tempStart = i;
            int tempPosition = i;
           
            while (tempSum < S && tempPosition < lenght) 
            {
                tempSum += array[tempPosition];
                tempPosition++;
            }
            if (tempSum == S) 
            {
                check = true;
                for (int j = tempStart; j < tempPosition; j++)
                {
                    Console.Write("{0} ", array[j]);
                }
                Console.WriteLine();
            }
        }
        if (!check) 
        {
            Console.WriteLine("No such sequence.");
        }
    }
}

