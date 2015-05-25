/*
Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
*/
using System;

class MaxSequence
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        bool check = false;
        int count = 1;
        int maxCount = 0;
        int firstIndex = 0;
        int firstIndexMax = 0;
        int lastNumber = array[0];
        for (int i = 1; i < array.Length; i++ )
        {
            int number = array[i];
            if (number > lastNumber)
            {
                if (check)
                {
                    count++;
                }
                else
                {
                    check = true;
                    count++;
                    firstIndex = i - 1;
                }
            }
            else
            {
                if (check)
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                        firstIndexMax = firstIndex;
                    }
                    count = 1;
                    check = false;                    
                }
            }
            lastNumber = number;
        }
        
        for (int i = firstIndexMax; i < firstIndexMax + maxCount; i++)
        {
            Console.Write("{0} ", array[i]); 
        }
        Console.WriteLine();
    }
}

