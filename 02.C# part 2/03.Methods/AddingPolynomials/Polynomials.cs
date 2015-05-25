/*
Problem 11. Adding polynomials

Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
****************************************************
Problem 12. Subtracting polynomials

Extend the previous program to support also subtraction and multiplication of polynomials.
 
*/

using System;
class Polynomials
{

    static void Main()
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 4, 3, 2, 1 };
        Add(a, b);
        Substract(a, b);
        Multiply(a, b);
    }

    static void Print(int[] array)
    {
        Console.Write("{0} * x^{1}", array[array.Length - 1], array.Length - 1);
        for (int i = array.Length - 2; i > 0; i--)
        {
            if (array[i] != 0)
            {
                if (array[i] > 0)
                {
                    Console.Write(" + ");
                    Console.Write("{0} * x^{1}", array[i], i);
                }
                else
                {
                    Console.Write(" - ");
                    Console.Write("{0} * x^{1}", Math.Abs(array[i]), i);
                }
            }
        }
        if (array[0] > 0) { Console.Write(" + " + array[0]); }
        else { Console.Write(" - " + Math.Abs(array[0])); }
        Console.WriteLine();
    }
    static void Add(int[] a, int[] b)
    {
        int lenA = a.Length;
        int lenB = b.Length;
        if (lenA > lenB)
        {
            int[] result = new int[lenA];
            int i = 0;
            for (; i < lenB; i++)
            {
                result[i] = a[i] + b[i];
            }
            for (; i < lenA; i++)
            {
                result[i] = a[i];
            }
            Print(result);
        }
        else
        {
            int[] result = new int[lenB];
            int i = 0;
            for (; i < lenA; i++)
            {
                result[i] = a[i] + b[i];
            }
            for (; i < lenB; i++)
            {
                result[i] = b[i];
            }
            Print(result);
        }
    }

    // always first - second (a - b)    
    static void Substract(int[] a, int[] b)
    {
        int lenA = a.Length;
        int lenB = b.Length;
        if (lenA > lenB)
        {
            int[] result = new int[lenA];
            int i = 0;
            for (; i < lenB; i++)
            {
                result[i] = a[i] - b[i];
            }
            for (; i < lenA; i++)
            {
                result[i] = a[i];
            }
            Print(result);
        }
        else
        {
            int[] result = new int[lenB];
            int i = 0;
            for (; i < lenA; i++)
            {
                result[i] = a[i] - b[i];
            }
            for (; i < lenB; i++)
            {
                result[i] = -b[i];
            }
            Print(result);
        }
    }
    static void Multiply(int[] a, int[] b) 
    {
        int lenA = a.Length;
        int lenB = b.Length;
        int[] result = new int[lenA + lenB - 1];

        for(int i = 0; i < lenA; i++)
        {
            for (int j = 0; j < lenB; j++)
            {
                result[i + j] += a[i] * b[j];
            }
        }

        Print(result);
    }


}

