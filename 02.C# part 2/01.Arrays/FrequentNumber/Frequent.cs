/*
Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
*/
using System;

class Frequent
{
    int[] array = new int[100000];
    static void Main()
    {
        int[] arrayPositive = new int[100000];
        int[] arrayNegative = new int[100000];
        int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, -5, -5, -5, -5, -5, -5};

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= 0)
            {
                arrayPositive[numbers[i]]++;
            }
            else
            {
                arrayNegative[Math.Abs(numbers[i])]++;
            }
        }

        int maxPositiveCount = 0;
        int maxNegativeCount = 0;
        int numberPositive = new int();
        int numberNegative = new int();
        for (int i = 0; i < arrayPositive.Length; i++)
        {
            if (arrayPositive[i] > maxPositiveCount)
            {
                maxPositiveCount = arrayPositive[i];
                numberPositive = i;
            }

            if (arrayNegative[i] > maxNegativeCount)
            {
                maxNegativeCount = arrayNegative[i];
                numberNegative = i;
            }
        }

        if (maxPositiveCount > maxNegativeCount)
        {
            Console.WriteLine("{0} ({1} times)", numberPositive, maxPositiveCount);
        }

        if (maxPositiveCount == maxNegativeCount) 
        {
            Console.WriteLine("{0} ({1} times)", numberPositive, maxPositiveCount);
            Console.WriteLine("-{0} ({1} times)", numberNegative, maxNegativeCount);
        }
        else
        {
            Console.WriteLine("-{0} ({1} times)", numberNegative, maxNegativeCount);
        }
        
    }
}

