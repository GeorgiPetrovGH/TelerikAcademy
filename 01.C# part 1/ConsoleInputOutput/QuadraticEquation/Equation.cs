/*
Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */

using System;
class Equation
{
    static void Main()
    {
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c= ");
        int c = int.Parse(Console.ReadLine());
        int d = b * b - 4 * a * c;
        if (d < 0)
        {
            Console.WriteLine("No real roots.");
        }
        else 
        {
            Console.WriteLine("x1 = {0}; x2 = {1}", (0.0 - b + Math.Sqrt(d)) / (2 * a), (0.0 - b - Math.Sqrt(d)) / (2 * a));
        }
    }
}

