namespace StringSequenceOccurences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string[] words = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            CalculateOddOccurences(words);
        }

        public static void CalculateOddOccurences(string[] words)
        {
            var occurencesCounter = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (occurencesCounter.ContainsKey(word))
                {
                    occurencesCounter[word]++;
                }
                else
                {
                    occurencesCounter.Add(word, 1);
                }
            }

            Console.Write("{" + string.Join(", ", words) + "} -> ");                     
            var oddCount = new List<string>();
            foreach (var pair in occurencesCounter)
            {
                if (pair.Value % 2 == 1)
                {   
                    oddCount.Add(pair.Key);
                }
            }

            Console.Write("{" + string.Join(", ", oddCount) + "}");
            Console.WriteLine();
        }
    }
}
