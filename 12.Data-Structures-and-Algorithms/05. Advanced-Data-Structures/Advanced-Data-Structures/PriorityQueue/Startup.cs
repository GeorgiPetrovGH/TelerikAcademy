namespace PriorityQueueImplementation
{
    using System;    

    public class Program
    {
        public static void Main()
        {
            var queue = new PriorityQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Enqueue(7);

            Console.WriteLine(queue.Peek());            
            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }
    }
}
