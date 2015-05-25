/*
Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits
(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;
class NumberArray
{
    static void Main(string[] args)
    {
        int number01 = 1111;
        int number02 = 123456;

        int[] array01 = DivideNumber(number01);
        int[] array02 = DivideNumber(number02);       
        int[] result = Add(array01, array02);
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write("{0} ", result[i]);
        }
        Console.WriteLine();
    }


    static int[] Add(int[] a, int[] b)
    {
        int lenA = a.Length;
        int lenB = b.Length;
        if (lenA > lenB)
        {
            int[] result = new int[lenA];
            int i = 0;
            int bonus = 0;
            int temp = 0;
            
            for (; i < lenB; i++)
            {
                temp = a[i] + b[i] + bonus;
                if (temp > 10)
                {
                    bonus = temp - 10;
                    temp -= 10;
                }
                else if (temp == 10) 
                {
                    bonus = 1;
                    temp = 0;
                }
                else { bonus = 0; }                
                result[i] = temp;
            }

            for (; i < lenA; i++)
            {
                temp = a[i] + bonus;
                if (temp > 10)
                {
                    bonus = temp - 10;
                    temp -= 10;
                }
                else if (temp == 10)
                {
                    bonus = 1;
                    temp = 0;
                }
                else { bonus = 0; }
                
                result[i] = temp;
            }
            return result;
        }
        
        else
        {
            int[] result = new int[lenB];
            int i = 0;
            int bonus = 0;
            int temp = 0;
            for (; i < lenA; i++)
            {
                temp = a[i] + b[i] + bonus;
                if (temp > 10)
                {
                    bonus = temp - 10;
                    temp -= 10;
                }
                else if (temp == 10) 
                {
                    bonus = 1;
                    temp = 0;
                }
                else { bonus = 0; }
                result[i] = temp;
            }
            for (; i < lenB; i++)
            {
                temp = b[i] + bonus;
                if (temp > 10)
                {
                    bonus = temp - 10;
                    temp -= 10;
                }
                else if (temp == 10)
                {
                    bonus = 1;
                    temp = 0;
                }
                else { bonus = 0; }
                result[i] = temp;
            }
            return result;
        }
    }
    static int[] DivideNumber(int number)
    {
        int len = FindLength(number);
        int[] array = new int[len];
        int x = number;
        int index = 0;
        while (x > 0)
        {
            array[index] = x % 10;
            index++;
            x /= 10;
        }
        return array;
    }
    static int FindLength(int number)
    {
        int x = number;
        int count = 0;
        while (x > 0)
        {
            count++;
            x /= 10;
        }
        return count;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}

