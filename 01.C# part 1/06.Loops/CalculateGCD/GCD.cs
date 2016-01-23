/*
Problem 17.* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
 */

using System;
class GCD
{
    static int gcd(int x, int y)
    {
        while (x > 0 && y > 0)
        {
            if (x < y) { y %= x; }
            else { x %= y; }            
        }
        if (x > 0) { return x; }
        else { return y; } 
    }
    
    static void Main()
    {
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD(a, b): {0}", gcd(a, b));
    }
    
}

