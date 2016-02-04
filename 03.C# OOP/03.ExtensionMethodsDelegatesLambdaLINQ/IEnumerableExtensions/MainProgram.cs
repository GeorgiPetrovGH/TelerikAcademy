/*
Problem 2. IEnumerable extensions

Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */

using System;
using System.Collections.Generic;

namespace IEnumerableExtensions
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            IEnumerable<int> test = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(test.Sum());
            Console.WriteLine(test.Max());
            Console.WriteLine(test.Min());
            Console.WriteLine(test.Product());
            Console.WriteLine(test.Average());            
        }
    }
}
