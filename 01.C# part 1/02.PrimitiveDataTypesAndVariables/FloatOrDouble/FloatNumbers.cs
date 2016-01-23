/*
Problem 2. Float or Double?
Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */
using System;

class FloatNumbers
{
    static void Main()
    {
        Console.WriteLine("These are double:");
        double number01 = 34.567839023;
        Console.WriteLine(number01);
        
        double number03 = 8923.1234857;
        Console.WriteLine(number03);

        Console.WriteLine("These are float:");
        float number02 = 12.345f;
        Console.WriteLine(number02);
        
        float number04 = 3456.091f;
        Console.WriteLine(number04);
    }
}

