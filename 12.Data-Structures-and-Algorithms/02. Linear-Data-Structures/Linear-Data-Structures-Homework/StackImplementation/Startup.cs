namespace StackImplementation
{
    using System;

    public class Startup
    {
        static void Main()
        {
            var testCustomStack = new CustomStack<int>();
            for (int i = 0; i < 10; i++)
            {
                testCustomStack.Push(i + 1);
            }

            Console.WriteLine("Stack size: {0}", testCustomStack.Count);

            while (testCustomStack.Count > 0)
            {
                Console.WriteLine("Stack current top element: {0}", testCustomStack.Pop());
            }
        }
    }
}
