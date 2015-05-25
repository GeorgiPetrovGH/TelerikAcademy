/*
Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
 */

using System;
class BinaryDecimal
    {
        static void Main()
        {
            long numberBin = 10011010010;
            Console.WriteLine(FindDecimal(numberBin));
        }

        static long FindDecimal(long x) 
        {
            long number = x;
            long result = 0;
            int cnt = 1;
            while (number > 0) 
            {
                result += (number % 10) * cnt;
                cnt *= 2;
                number /= 10;
            }
            return result;
        }
    }

