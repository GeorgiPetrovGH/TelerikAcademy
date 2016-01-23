/*
Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 */

using System;
class Fibonacci
{
    static void Main()
    {
        
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        
        int fib01 = 0;
        int fib02 = 1;

        if (number == 1) 
        {
            Console.Write(fib01);
        }
        else if(number == 2)
        {
            Console.WriteLine("{0}, {1}", fib01, fib02);
        }
        else if (number >= 3) 
        {
            Console.Write("{0}, {1}, ", fib01, fib02);
            for (int i = 2; i < number - 1; i++)
            {                
                Console.Write("{0}, ", fib01 + fib02);
                int fib03 = fib01;
                fib01 = fib02;
                fib02 = fib03 + fib02;
            }
            Console.WriteLine(fib01 + fib02);
        }
            
    }
}

