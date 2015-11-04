namespace WordsOccurrences
{
    using System;    
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            string filePath = "..\\..\\words.txt";

            var separator = new Regex("[^A-Za-z']");

            string text = File.ReadAllText(filePath);

            var occurenceCounter = separator.Split(text.ToLower())
                                            .Where(w => !string.IsNullOrEmpty(w))
                                            .GroupBy(w => w)
                                            .ToDictionary(gr => gr.Key, gr => gr.Count())
                                            .OrderBy(pair => pair.Value);

            Console.WriteLine(text);
            foreach (var pair in occurenceCounter)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
