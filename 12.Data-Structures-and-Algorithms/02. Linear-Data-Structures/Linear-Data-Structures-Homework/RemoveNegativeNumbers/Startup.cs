namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            var numbers = new List<int>() { 1, -2, 20, 3, -3, 30, 6, -6, -6, 60, 5, -5, 50, -5, 50, 4, -4, -4, 40 };
            Console.WriteLine("Original list");
            Console.WriteLine(string.Join(", ", numbers));

            numbers.RemoveAll(x => x < 0);
            Console.WriteLine("With only positive numbers");
            Console.WriteLine(string.Join(", ", numbers));

            //second option
            var noNegative = numbers.Where(x => x >= 0);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
