/*
Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/

using System;
class GetMax
{
    static void Main()
    {
        int a = 10;
        int b = 15;
        int c = 5;
        Console.WriteLine(GetMaxNum(GetMaxNum(a,b), c));
    }

    static int GetMaxNum(int x, int y) 
    {
        int greater = x >= y ? x : y;
        return greater;
    }
}

