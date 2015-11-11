namespace Permutations
{
    using System;

    public class Startup
    {
        private static int[] vector;
        private static int n;
        private static bool[] used;

        public static void Main()
        {
            Console.WriteLine("Enter integer number n and press ENTER:");
            n = int.Parse(Console.ReadLine());

            vector = new int[n];
            used = new bool[n + 1];

            GeneratePermutations(0);
        }

        private static void GeneratePermutations(int index)
        {
            if (index == n)
            {
                Console.WriteLine(string.Join(", ", vector));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (!used[i])
                {
                    vector[index] = i;
                    used[i] = true;
                    GeneratePermutations(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
