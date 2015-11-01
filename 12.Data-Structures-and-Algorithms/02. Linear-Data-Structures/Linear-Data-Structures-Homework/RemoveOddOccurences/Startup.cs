namespace RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            var numbers = new List<int>() { 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 5, 5, 5, 6, 6 };
            Console.WriteLine("Original list");
            Console.WriteLine(string.Join(", ", numbers));
            var numbersCount = CalculateOccurence(numbers);   
            foreach (var item in numbersCount)
            {
                if (item.Value % 2 == 1)
                {
                    numbers.RemoveAll(x => x == item.Key);
                }
            }

            Console.WriteLine("Filtered list");
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static Dictionary<int, int> CalculateOccurence(List<int> numbers)
        {
            var result = new Dictionary<int, int>();
            foreach(var number in numbers)
            {
                if(!result.ContainsKey(number))
                {
                    result[number] = 0;
                }

                result[number]++;                
            }

            return result;
        }        
    }
}
