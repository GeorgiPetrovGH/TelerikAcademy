/*
Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
 */

using System;
 class Sum
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            double count = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter number: ");  
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }

