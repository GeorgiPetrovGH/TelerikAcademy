/*
Problem 7. Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/

using System;
class Circle
{
    static void Main()
    {
        Console.Write("Enter X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        
        double distance = Math.Sqrt(x * x + y * y);
        Console.WriteLine("Is the point in the circle?");
        if (distance <= 2)
        {
            Console.WriteLine("true");
        }
        else 
        {
            Console.WriteLine("false");
        }
               
       
    }
}

