/*
Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
 */

using System;
class BiggestNumber5
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double number01 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double number02 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double number03 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double number04 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double number05 = double.Parse(Console.ReadLine());

        if (number01 >= number02 && number01 >= number03 && number01 >= number04 && number01 >= number05)
        {
            Console.WriteLine("The biggest number is: {0}", number01);
        }
        else if (number02 >= number01 && number02 >= number03 && number02 >= number04 && number02 >= number05)
        {
            Console.WriteLine("The biggest number is: {0}", number02);
        }
        else if (number03 >= number01 && number03 >= number02 && number03 >= number04 && number03 >= number05)
        {
            Console.WriteLine("The biggest number is: {0}", number03);
        }
        else if (number04 >= number01 && number04 >= number02 && number04 >= number03 && number04 >= number05)
        {
            Console.WriteLine("The biggest number is: {0}", number04);
        }
        else
        {
            Console.WriteLine("The biggest number is: {0}", number05);
        }

    }
}

