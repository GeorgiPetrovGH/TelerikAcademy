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

    static T FindMin<T>(params T[] array) where T : IComparable<T>
    {
        int index = 0;        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[index]) < 0) 
            {
                index = i;
            } 
        }
        return array[index];
    }

    static T FindMax<T>(params T[] array) where T : IComparable<T>
    {
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[index]) > 0)
            {
                index = i;
            }
        }
        return array[index];
    }

    static T FindSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static T FindAverage<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }

    static T FindProduct<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

}

