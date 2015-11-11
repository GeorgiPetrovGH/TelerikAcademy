namespace Variations
{
    using System;

    public class Startup
    {
        private static string[] words;
        private static string[] result;
        private static int k;
        private static int n;

        public static void Main()
        {
            Console.WriteLine("Enter integer number n and press ENTER:");
            n = int.Parse(Console.ReadLine());
            words = GenerateRandomStringArray(n);

            Console.WriteLine("Enter integer number k and press ENTER:");
            k = int.Parse(Console.ReadLine());
            result = new string[k];

            GenerateVariations(0);
        }

        private static string[] GenerateRandomStringArray(int length)
        {
            var array = new string[n];

            for (int i = 0; i < length; i++)
            {
                array[i] = ((char)('a' + i)).ToString();
            }

            return array;
        }

        private static void GenerateVariations(int index)
        {
            if (index == k)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }

            for (int i = 0; i < words.Length; i++)
            {
                result[index] = words[i];
                GenerateVariations(index + 1);
            }
        }
    }
}
