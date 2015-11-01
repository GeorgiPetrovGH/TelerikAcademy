namespace SortList
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            //Enter numbers from the console
            //var numbers = EnterNumbersFromConsole();

            //Or if you are lazy as me, use the prepared List
            var numbers = new List<int>() { 7, 2, 1, 120, 70 };
            numbers.Sort();
            Console.WriteLine(string.Join(",", numbers));
        }

        public static ICollection<int> EnterNumbersFromConsole()
        {
            ICollection<int> result = new List<int>();

            string line = Console.ReadLine().Trim();

            while (line != string.Empty)
            {
                int number = int.Parse(line);
                result.Add(number);
                line = Console.ReadLine().Trim();
            }

            return result;
        }
    }
}
