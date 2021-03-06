﻿/*
Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */

using System;
class Product
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] array = numbers.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= Convert.ToInt32(array[i]);
            }
            else 
            {
                evenProduct *= Convert.ToInt32(array[i]);
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
        }
        else 
        {
            Console.WriteLine("no");
        }

    }
}

