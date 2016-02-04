/*
Problem 17. Longest string

Write a program to return the string with maximum length from an array of strings.
Use LINQ.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class MainProgram
    {
        static void Main()
        {
            string[] someStrings =
                                    {
                                    "string",
                                    "pesho",
                                    "longeststring",
                                    "somestring",
                                    "gosho"
                                    };

            var sorted =
                        from strings in someStrings
                        orderby strings.Length descending
                        select strings;
            
            string longest = sorted.FirstOrDefault();
            Console.WriteLine(longest);
        }
    }
}
