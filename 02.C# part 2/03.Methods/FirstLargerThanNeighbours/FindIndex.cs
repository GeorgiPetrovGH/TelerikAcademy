/*
Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

using System;
class FindIndex
{
    static void Main()
    {
        int[] array = { 1, 2, 7, 5, 3, 2, 1, 1, 5, 9, 8, 0};
        Console.WriteLine(findLarger(array));
    }

    static int findLarger(int[] array)
    {
        int len = array.Length;
        if (array[0] > array[1]) 
        { 
            return 0; 
        }
        for (int i = 1; i < len -1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1]) 
            {
                return i;
            }
        }
        if (array[len - 1] > array[len - 2]) 
        {
            return len - 1;
        }
        return -1;
    }
}

