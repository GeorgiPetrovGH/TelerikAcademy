namespace Method_PrintStatistics
{
    using System;
    using System.Collections.Generic;
    
    public static class ArrayMethods
    {
        public static void PrintStatistics<T>(this T[] numbers) where T : IComparable
        {
            string result = "";

            result += "Max: " + FindMax(numbers) + "\n" +
                        "Min: " + FindMin(numbers) + "\n" +
                        "Average: " + FindAverage(numbers);

            Console.WriteLine(result);
        }

        public static T FindMax<T>(this T[] numbers) where T : IComparable
        {
            T max = numbers[0];
            int len = numbers.Length;
            for (int i = 1; i < len; i++)
            {
                if (numbers[i].CompareTo(max)>0)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        public static T FindMin<T>(this T[] numbers) where T : IComparable
        {
            T min = numbers[0];
            int len = numbers.Length;
            for (int i = 1; i < len; i++)
            {
                if (numbers[i].CompareTo(min) < 0)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public static T FindAverage<T>(this T[] numbers) where T : IComparable
        {
            dynamic sum = 0; 
            int len = numbers.Length;
            
            for (int i = 1; i < len; i++)
            {
                sum += numbers[i];
            }

            return sum/len;
        }
    }
}
