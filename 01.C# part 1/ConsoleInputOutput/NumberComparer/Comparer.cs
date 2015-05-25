/*
Problem 4. Number Comparer
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
 */

using System;
 class Comparer
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int greater = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine("Greater: {0}",greater);
        }
    }
