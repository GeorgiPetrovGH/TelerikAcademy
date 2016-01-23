/*
Problem 9. Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

using System;
class Trapezoid
{
    static void Main()
    {
        Console.Write("Enter Side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter Side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter Height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine((sideA + sideB) * 0.5 * height);
    }
}
