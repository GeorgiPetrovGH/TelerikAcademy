/*
Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */

using System;
using System.Collections.Generic;
class MaxSum{
    
    static int findMaxNumber(List<int> list)
    {
        int maxNumber = int.MinValue;
        foreach (int number in list)
        {
            if (number > maxNumber) 
            {
                maxNumber = number;
            }
        }
        list.Remove(maxNumber);
        return maxNumber;
    }
    static void Main()
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());           
           
            List<int> elements = new List<int>();            
            
            if (K > N)
            {
                Console.WriteLine("Invalid input.");
            }
            else 
            {                
                for (int i = 0; i < N; i++)
			    {
			        Console.Write("Enter Integer: ");
                    elements.Add(int.Parse(Console.ReadLine()));
			    }
                Console.WriteLine("K elements with maximal sum:");
                for (int i = 0; i < K; i++)
			    {
			        Console.Write("{0} ",findMaxNumber(elements));
			    }
                Console.WriteLine();	
            }
        }
}

