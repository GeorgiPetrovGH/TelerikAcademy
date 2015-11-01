namespace QueueSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            //int start = int.Parse(Console.ReadLine());
            int start = 2;
            int count = 50;
            PrintSequence(start, count);
        }

        public static void PrintSequence(int start, int count)
        {
            Queue<int> container = new Queue<int>();
            container.Enqueue(start);
            var result = new Queue<int>();
            //result.Enqueue(start);

            while (result.Count < count)
            {
                int currentNumber = container.Dequeue();
                result.Enqueue(currentNumber);

                int firstNextNumber = currentNumber + 1;
                int secondNextNumber = currentNumber * 2 + 1;
                int thirdNextNumber = currentNumber + 2;

                container.Enqueue(firstNextNumber);
                container.Enqueue(secondNextNumber);
                container.Enqueue(thirdNextNumber);

                //result.Enqueue(firstNextNumber);
                //result.Enqueue(secondNextNumber);
                //result.Enqueue(thirdNextNumber);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
