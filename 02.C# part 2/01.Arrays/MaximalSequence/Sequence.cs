/*
Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
*/
using System;

class Sequence
{
    static void Main()
    {
        int[] array = {2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        bool check = false;
        int count = 1;
        int maxCount = 0;
        int lastNumber = int.MinValue;
        foreach (int number in array)
        {
            if (number == lastNumber)
            {
                if (check)
                {
                    count++;
                }
                else
                {
                    check = true;
                    count++;
                }               
            }
            else 
            {
                if (check)
                {
                    if (maxCount < count)
                    {
                        maxCount = count;                        
                        
                    }
                    count = 1;
                    check = false;
                }
                
            }
            lastNumber = number;
        }
        Console.WriteLine(maxCount);

    }
}

