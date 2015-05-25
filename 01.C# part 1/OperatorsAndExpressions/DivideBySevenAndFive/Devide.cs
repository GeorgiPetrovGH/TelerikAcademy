/*
Problem 3. Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
*/

using System;
class Devide
{
    static void Main()
    {
        Console.Write("Enter Integer Number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 35 == 0)
        {
            Console.WriteLine("true");
        }
        else 
        {
            Console.WriteLine("false");
        }
    }
}

