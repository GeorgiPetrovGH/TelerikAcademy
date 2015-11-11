namespace CombinationsWithoutDuplicates
{
    using System;

    public class Startup
    {
        private static int[] vector;
        private static int n;
        private static int k;

        public static void Main()
        {
            Console.WriteLine("Enter integer number n and press ENTER:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer number k and press ENTER:");
            k = int.Parse(Console.ReadLine());

            vector = new int[k];

            GenerateCombinations(0, 1);
        }

        private static void GenerateCombinations(int index, int start)
        {
            if (index == k)
            {
                Console.WriteLine(string.Join(", ", vector));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                vector[index] = i;

                GenerateCombinations(index + 1, i + 1);
            }
        }
    }
}
