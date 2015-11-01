namespace LinkedList
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            var myList = new LinkedList<int>();

            Console.WriteLine("Adding two elements");
            myList.AddLast(6);
            myList.AddLast(12);
            Console.WriteLine("First element -> {0}", myList.FirstItem);

            Console.WriteLine("Adding first element:");
            myList.AddFirst(3);
            Console.WriteLine("First element -> {0}", myList.FirstItem);

            myList.AddLast(25);
            Console.WriteLine("Removing the first element:");
            myList.RemoveFirst();
            Console.WriteLine("First element -> {0}", myList.FirstItem);
        }
    }
}
