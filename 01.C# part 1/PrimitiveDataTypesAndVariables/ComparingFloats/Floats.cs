/*
Problem 13.* Comparing Floats
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
*/

using System;

 class Floats
    {
        static void Main()
        {
            double eps = 0.000001;
            double a = 5.3;
            double b = 6.1;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.Write("a equals b? : " );
            Console.Write(Math.Abs(a - b) < eps);
            Console.WriteLine();

            a = 5.00000001;
            b = 5.00000003;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.Write("a equals b? : ");
            Console.Write(Math.Abs(a - b) < eps);
            Console.WriteLine();

            a = -4.999999;
            b = -4.999998;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.Write("a equals b? : ");
            Console.Write(Math.Abs(a - b) < eps);
            Console.WriteLine();

        }
    }

