/*
Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/
using System;
using System.Numerics;
class Factorial
{
    static int n = 20;
    static BigInteger[] array = new BigInteger[n+1];
    static void Main()
    {
        array[0] = 1;
        WriteFactorial();
        PrintArray();
    }

    static void WriteFactorial()
    {        
        for (int i = 1; i <= n; i++)
			{
			    array[i] = array[i-1] * i;
			}
    }

    static void PrintArray()
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}

