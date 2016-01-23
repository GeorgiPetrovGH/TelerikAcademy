/*
Problem 10. Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

using System;
class Point
{
    static void Main()
    {
        Console.Write("Enter X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        double sideX = x - 1;
        double sideY = y - 1;
        double distanceCenter = Math.Sqrt(sideX * sideX + sideY * sideY);
        
        bool inCircle = false;
        bool outRect = false;
        
        if (distanceCenter <= 1.5) 
        {
            inCircle = true;
        }
        if (x > 5 || x < -1 || y > 1 || y < -1) 
        {
            outRect = true;
        }
        Console.WriteLine("Point In Circle & Out Rectangle?");
        if (inCircle && outRect) 
        {
            Console.WriteLine("yes");
        }
        else 
        {
            Console.WriteLine("no");
        }
    }
}