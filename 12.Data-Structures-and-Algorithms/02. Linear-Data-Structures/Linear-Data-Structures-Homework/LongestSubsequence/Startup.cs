namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            var numbers = new List<int>() { 1, 2, 2, 3, 3, 3, 6, 6, 6, 6, 6, 6, 5, 5, 5, 5, 5, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7 };
            Console.WriteLine("Original list");
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("Max sequence");            
            var maxSequence = FindLongestSequenceOfEqualNumbers(numbers);
            Console.WriteLine(string.Join(",", maxSequence));
        }

        public static List<int> FindLongestSequenceOfEqualNumbers(List<int> numbers)
        {
            if(numbers == null)
            {
                throw new ArgumentNullException();
            }
            
            if(numbers.Count == 0)
            {
                throw new ArgumentNullException();
            }
            
            if (numbers.Count == 1)
            {
                return numbers;
            }
            
            var result = new List<int>();
            var previousNumber = numbers[0];
            var foundSequel = false;
            var maxSequelNumber = 0;
            var currentCount = 1;
            var maxCount = 0;
            for (var i = 1; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber == previousNumber)
                {
                    if(foundSequel)
                    {
                        currentCount++;
                    }
                    else
                    {
                        foundSequel = true;
                        currentCount++;
                    }

                }
                else
                {
                    if (foundSequel)
                    {
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            maxSequelNumber = previousNumber;
                        }
                        foundSequel = false;
                        currentCount = 1;
                    }
                }

                previousNumber = currentNumber;
            }

            if (foundSequel)
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxSequelNumber = previousNumber;
                }                
            }

            for (var i = 0; i < maxCount; i++)
            {
                result.Add(maxSequelNumber);
            }

            return result;
        }
    }
}
