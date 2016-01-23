/*
Problem 12. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

using System;

 class NullValues
    {
        static void Main()
        {
            int? integerNumber = new int();
            double? doubleNumber = new double();
            Console.WriteLine("Integer number = " + integerNumber);
            Console.WriteLine("Double number  = " + doubleNumber);
            integerNumber = 10;
            doubleNumber = null;
            Console.WriteLine("Integer number = " + integerNumber);
            Console.WriteLine("Double number  = " + doubleNumber);
        }
    }

