/*
Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
 */

using System;
class BiggestNumber3
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
            Console.WriteLine("The biggest number is: {0}", number01);
        }
        else if (number02 >= number01 && number02 >= number03)
        {
            Console.WriteLine("The biggest number is: {0}", number02);
        }
        else 
        {
            Console.WriteLine("The biggest number is: {0}", number03);
        }

    }
}

