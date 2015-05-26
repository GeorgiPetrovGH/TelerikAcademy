/*
Problem 1. Shapes

Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure
(height * width for rectangle and height * width/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class MainProgram
    {
        static void Main()
        {
            Shape[] shapes =
                            {
                            new Rectangle(2.5, 7.5),
                            new Square(5),
                            new Triangle(6.5, 4),
                            new Rectangle(7, 2),
                            new Triangle(2, 3)
                            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("This {0} area is: {1}", shape.GetType().Name.ToLower(), shape.CalculateSurface());
            }
        }
    }
}
