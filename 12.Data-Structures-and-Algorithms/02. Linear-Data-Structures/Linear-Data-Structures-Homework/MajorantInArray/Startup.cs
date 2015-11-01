namespace CountOccurences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            var numbers = new int[] { 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
            Console.WriteLine("Original list");
            Console.WriteLine(string.Join(", ", numbers));
            var numbersCount = CountOccurences(numbers);
            var majorantCount = (numbers.Length / 2) + 1;            
            foreach (var item in numbersCount)
            {
                if(item.Value >= majorantCount)
                {
                    Console.WriteLine("Majorant is {0}: {1} times", item.Key, item.Value);
                }
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
