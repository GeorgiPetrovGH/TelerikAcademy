/*
Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/

using System;
 class Rectangle
    {
        static void Main()
        {
            Console.Write("Enter Rectangle's Height: ");
            double height = double.Parse(Console.ReadLine());            
            Console.Write("Enter Rectangle's Width: ");            
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter: " + 2 * (height + width));
            Console.WriteLine("Area: " + height * width);
        }
    }

