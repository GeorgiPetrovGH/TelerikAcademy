namespace IntegerSequelList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            //Enter numbers from the console
            //var numbers = EnterNumbersFromConsole();
            
            //Or if you are lazy as me, use the prepared List
            var numbers = new List<int>() { 7, 2, 1, 120, 70 };
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
        }

        public static ICollection<int> EnterNumbersFromConsole()
        {
            ICollection<int> result = new List<int>();
            
            string line = Console.ReadLine().Trim();

            while(line != string.Empty)
            {
                int number = int.Parse(line);
                result.Add(number);
                line = Console.ReadLine().Trim();
            }

            return result;
        }
    }
}
