namespace SubsetsOfStrings
{
    using System;

    public class Startup
    {
        private static int k = 2;
        private static string[] words = { "test", "rock", "fun" };
        private static string[] result = new string[k];        

        public static void Main()
        {
            GenerateVariatons(0, 0);
        }

        private static void GenerateVariatons(int index, int start)
        {
            if (index == k)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }

            for (int i = start; i < words.Length; i++)
            {
                result[index] = words[i];
                GenerateVariatons(index + 1, i + 1);
            }
        }
    }
}
