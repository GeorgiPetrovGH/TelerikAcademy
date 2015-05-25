/*
Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
 */

using System;
class Multiplication
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double number01 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double number02 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double number03 = double.Parse(Console.ReadLine());

        if (number01 == 0 || number02 == 0 || number03 == 0) 
        {
            Console.WriteLine(0);
        }
        else if (number01 > 0) 
        {
            if ((number02 > 0 && number03 > 0) || (number02 < 0 && number03 < 0))
            {
                Console.WriteLine("+");
            }
            else 
            {
                Console.WriteLine("-");
            }
        }
        else 
        {
            if ((number02 > 0 && number03 > 0) || (number02 < 0 && number03 < 0))
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }

    }
}

