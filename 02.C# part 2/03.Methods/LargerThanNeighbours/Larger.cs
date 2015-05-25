/*
Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/

using System;
class Larger
{
    static void Main()
    {
        int[] array = { 1, 0, 7, 5, 3, 2, 1, 1, 5, 9, 8, 0, 3, 2, 5, 7, 3, 1, 2, 3, 1, 2, 6, 1, 9, 1, 0, 6, 7, 9, 0, 4, 3, 5 };
       
        Random rand = new Random();
        int index = rand.Next(0,array.Length + 1);
        
        Console.WriteLine("index = {0}", index);
        
        if (index > 0 && index < array.Length)
        {
            Console.WriteLine("{0} {1} {2}", array[index - 1], array[index], array[index + 1]);
        }
        if (index == 0) 
        {
            Console.WriteLine("{0} {1}", array[index], array[index + 1]);
        }
        if(index == array.Length + 1)
        {
            Console.WriteLine("{0} {1}", array[index - 1], array[index]);
        }        
        
        Console.WriteLine(checkLarger(array, index));

    }

    static bool checkLarger(int[] array, int index)
    {
        if (index < 0)
        {
            return false;
        }
        else if (index == 0)
        {
            if (array[0] > array[1]) { return true; }
            else { return false; }
        }
        else if (index == array.Length - 1)
        {
            if (array[index] > array[index -1]) { return true; }
            else { return false; }
        }
        else if (index < array.Length - 1) 
        {
            if (array[index] > array[index - 1] && array[index] > array[index+1]) { return true; }
            else { return false; }
        }
        else 
        {
            return false;
        }
    }
}

