/*
Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 */

using System;
class Randomize
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Invalid input.");
            }
            else 
            {
                int count = 0;
                Random rand = new Random();
                bool[] array = new bool[n+1];
                while (count < n) 
                {
                    int number = rand.Next(1, n + 1);
                    if (array[number] == false) 
                    {
                        array[number] = true;
                        count++;
                        Console.Write("{0} ", number);
                    }
                }
			
            }
        }
    }

