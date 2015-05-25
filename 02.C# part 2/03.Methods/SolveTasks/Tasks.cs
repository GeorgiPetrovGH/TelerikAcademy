/*
Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 
*/

using System;
using System.Collections.Generic;
class Tasks
{
    static void Main()
    {
        Console.WriteLine("Which task to solve: ");
        Console.WriteLine("1 -> Reverses the digits of a number");
        Console.WriteLine("2 -> Calculates the average of a sequence of integers");
        Console.WriteLine("3 -> Solves a linear equation a * x + b = 0");
        Console.WriteLine("0 -> Exit");

        int choice = -1;
        List<int> list = new List<int>();
        int number = new int();
        
        while (choice < 0 || choice > 3) 
        {
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
        }
        switch (choice)
        {
            case 1:
                number = -1;
                while (number < 0)
                {
                    Console.Write("Enter number: ");
                    number = int.Parse(Console.ReadLine());
                }
                Console.Write("Reversed number is: ");
                Console.WriteLine(findReversedNumber(number));
                break;

            case 2:
                int more = -1;
                while (more != 0)
                {
                    Console.Write("Enter integer: ");
                    number = int.Parse(Console.ReadLine());
                    list.Add(number);
                    Console.Write("Do you want to enter a number (0 -> No, else -> Yes)");
                    more = int.Parse(Console.ReadLine());
                }                               

                Console.Write("Average is: ");
                Console.WriteLine(FindAverage(list));
                break;

            case 3:
                int a = 0;
                while (a == 0) 
                {
                    Console.Write("a= ");
                    a = int.Parse(Console.ReadLine());
                }
                Console.Write("b= ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("x = {0}", SolveEquation(a,b));
                Console.WriteLine();
                break;
        }
    }

    static int findReversedNumber(int x)
    {
        if (x < 0)
        {
            return -1;
        }
        else
        {
            int number = x;
            int reversed = 0;
            while (number > 0)
            {
                reversed = (10 * reversed) + (number % 10);
                number /= 10;
            }
            return reversed;
        }
    }

    static double FindAverage(List<int> list) 
    {
        int cnt = 0;
        int average = 0;

        if (list.Count != 0)
        {
            foreach (var item in list)
            {
                average += item;
                cnt++;
            }
            return (double) average / cnt;
        }
        else { return -1; }
    }

    static double SolveEquation(int a, int b) 
    {
        return (double) -b/ a;
    }
}

