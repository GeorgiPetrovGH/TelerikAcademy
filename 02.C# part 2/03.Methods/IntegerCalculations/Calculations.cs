/*
Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 
*/

using System;
class Calculations
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Min element: {0}", FindMin(array));
        Console.WriteLine("Max element: {0}", FindMax(array)); 
        Console.WriteLine("Average element: {0}", FindAverage(array));
        Console.WriteLine("Sum: {0}", FindSum(array));
        Console.WriteLine("Product: {0}", FindProduct(array));
    }

    static int FindMin(params int[] array) 
    {
        int minValue = int.MaxValue;
        foreach (int number in array)
        {
            if (number < minValue) 
            {
                minValue = number;
            }
        }
        return minValue;
    }

    static int FindMax(params int[] array)
    {
        int maxValue = int.MinValue;
        foreach (int number in array)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }
        return maxValue;
    }

    static int FindSum(params int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum;
    }

    static int FindAverage(params int[] array)
    {
        int sum = 0;
        int cnt = 0;
        foreach (int number in array)
        {
            sum += number;
            cnt++;
        }
        return sum/cnt;
    }

    static int FindProduct(params int[] array)
    {
        int product = 1;
        foreach (int number in array)
        {
            product *= number;
        }
        return product;
    }

}

