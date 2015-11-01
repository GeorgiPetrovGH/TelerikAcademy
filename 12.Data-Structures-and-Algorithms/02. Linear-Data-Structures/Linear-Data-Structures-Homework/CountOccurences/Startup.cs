namespace CountOccurences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            var numbers = new int[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6 };
            Console.WriteLine("Original array");
            Console.WriteLine(string.Join(", ", numbers));
            var numbersCount = CountOccurences(numbers);
            Console.WriteLine("Occurences");
            foreach(var item in numbersCount)
            {
                Console.WriteLine(item);
            }
        }

        public static Dictionary<int, int> CountOccurences(int[] numbers)
        {
            var result = new Dictionary<int, int>();
            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }

                result[number]++;
            }

            return result;
        } 
    }
}
