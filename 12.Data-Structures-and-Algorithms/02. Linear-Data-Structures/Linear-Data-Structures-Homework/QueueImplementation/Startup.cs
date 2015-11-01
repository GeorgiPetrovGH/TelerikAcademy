namespace QueueImplementation
{
    using System;

    public class Startup
    {
        static void Main()
        {
            var myQueue = new CustomQueue<string>();

            Console.WriteLine("Adding 3 elements in the queue:");
            myQueue.Enqueue("pesho");
            myQueue.Enqueue("gosho");
            myQueue.Enqueue("stamat");            
            Console.WriteLine("Count -> {0}", myQueue.Count);
            Console.WriteLine("Peek -> {0}", myQueue.Peek());
            Console.WriteLine("Dequeue -> {0}", myQueue.Dequeue());
            Console.WriteLine("Count -> {0}", myQueue.Count);            
            Console.WriteLine("Contains pesho -> {0}", myQueue.Contains("pesho"));            
        }
    }
}
