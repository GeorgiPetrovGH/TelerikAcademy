/*
 Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
As a result print the values a and b, separated by a space.
 */

using System;
class Exchange
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                double c = firstNumber;
                firstNumber = secondNumber;
                secondNumber = c;
            }
            Console.WriteLine("First number = {0}, Second number = {1}", firstNumber, secondNumber);
        }
    }

