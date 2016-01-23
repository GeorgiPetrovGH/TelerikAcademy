/*
Problem 3. Circle Perimeter and Area
Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */

using System;
class Circle
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        Console.WriteLine("Perimetyr: {0:0.00}", 2 * pi * radius);
        Console.WriteLine("Area     : {0:0.00}", pi * radius * radius);
    }
}

