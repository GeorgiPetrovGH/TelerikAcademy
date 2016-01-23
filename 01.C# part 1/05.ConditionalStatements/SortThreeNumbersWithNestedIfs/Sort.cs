/*
Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
 */

using System;
class Sort
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double number01 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double number02 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double number03 = double.Parse(Console.ReadLine());
        
        if (number01 >= number02 && number01 >= number03) 
        {
            if (number02 >= number03)
            {
                Console.WriteLine("{0} {1} {2}", number01, number02, number03);
            }
            else 
            {
                Console.WriteLine("{0} {1} {2}", number01, number03, number02);
            }
        }
        else if (number02 >= number03 && number02 >= number01)
        {
            if (number01 >= number03)
            {
                Console.WriteLine("{0} {1} {2}", number02, number01, number03);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", number02, number03, number01);
            }
        }
        else 
        {
            if (number01 >= number02)
            {
                Console.WriteLine("{0} {1} {2}", number03, number01, number02);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", number03, number02, number01);
            }
        }

    }
}

