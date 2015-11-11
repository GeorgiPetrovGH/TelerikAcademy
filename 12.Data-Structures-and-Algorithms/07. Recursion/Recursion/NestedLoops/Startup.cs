namespace NestedLoops
{
    using System;

    public class Startup
    {
        private static int[] vector;
        private static int n;

        public static void Main()
        {
            Console.WriteLine("Enter integer number n and press ENTER:");
            n = int.Parse(Console.ReadLine());
            vector = new int[n];

            GenerateLoops(0);
        }

        private static void GenerateLoops(int index)
        {
            if (index == n)
            {
                Console.WriteLine(string.Join(", ", vector));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                vector[index] = i;

                GenerateLoops(index + 1);
            }
        }
    }
}
