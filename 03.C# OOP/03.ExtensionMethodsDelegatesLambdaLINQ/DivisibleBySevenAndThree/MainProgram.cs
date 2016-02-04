/*
Problem 5. Order students
Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
Rewrite the same with LINQ.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace DivisibleBySevenAndThree
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 42, 1, 20, 3, 18, 5, 16, 7, 14, 9, 63, 12, 11, 10, 13, 8, 15, 6, 17, 4, 19, 21 };
            Console.WriteLine("Array of numbers:");
            Console.WriteLine(string.Join(", ", array));
            
            
            var resultLinq = from number in array
                             where number % 3 == 0 && number % 7 == 0
                             select number;
            Console.WriteLine("Operation with Linq");
            Console.WriteLine(string.Join(", ", resultLinq));

            var resultLambda = array.Where(x => x % 3 == 0 && x % 7 == 0);
            Console.WriteLine("Operation with Lambda");
            Console.WriteLine(string.Join(", ", resultLambda));
        }
    }
}
