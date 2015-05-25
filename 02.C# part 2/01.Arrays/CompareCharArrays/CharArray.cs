/*
Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
*/
using System;

class CharArray
{
    static void Main()
    {

        Console.WriteLine("First array length: ");
        int lenArray01 = int.Parse(Console.ReadLine());
        Console.WriteLine("Second array length: ");
        int lenArray02 = int.Parse(Console.ReadLine());
        char[] array01 = new char[lenArray01];
        char[] array02 = new char[lenArray02];

        for (int i = 0; i < Math.Min(lenArray01, lenArray02); i++)
        {
            Console.Write("First array char: ");
            array01[i] = char.Parse(Console.ReadLine());
            Console.Write("Second array char: ");
            array02[i] = char.Parse(Console.ReadLine());
            if (array01[i] < array02[i])
            {
                Console.WriteLine("Second array is greater.");
                break;
            }
            else if (array01[i] > array02[i])
            {
                Console.WriteLine("First array is greater.");
                break;
            }

            if (lenArray01 > lenArray02)
            {
                if (i == lenArray02 - 1)
                {
                    Console.WriteLine("First array is greater.");
                }
            }
            else if (lenArray01 < lenArray02)
            {
                if (i == lenArray01 - 1)
                {
                    Console.WriteLine("Second array is greater.");
                }
            }

        }
    }
}

