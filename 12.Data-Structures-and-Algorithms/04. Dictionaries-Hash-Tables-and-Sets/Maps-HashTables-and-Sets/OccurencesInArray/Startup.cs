namespace OccurencesInArray
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            double[] numbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            CalculateOccurences(numbers);            
        }

        public static void CalculateOccurences(double[] numbers)
        {
            var occurencesCounter = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (occurencesCounter.ContainsKey(number))
                {
                    occurencesCounter[number]++;
                }
                else
                {
                    occurencesCounter.Add(number, 1);
                }
            }

            Console.WriteLine("{ " + string.Join(", ", numbers) + " }");
            foreach (var pair in occurencesCounter)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
