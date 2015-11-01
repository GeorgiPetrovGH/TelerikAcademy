namespace ReverseIntStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            //Enter numbers from the console
            //var numbers = EnterNumbersFromConsole();

            //Or if you are lazy as me, use the prepared Stack           
            var numbers = new Stack<int>(new[] { 7, 2, 1, 120, 70 });
            //Here is the stackoverflow explaining why this works
            //http://stackoverflow.com/questions/3297717/does-stack-constructor-reverse-the-stack-when-being-initialized-from-other-one
            var reversedNumbers = new Stack<int>(numbers);

            Console.WriteLine("Original stack");
            PrintStack(numbers);
            Console.WriteLine("Reversed stack");
            PrintStack(reversedNumbers);
        }

        public static IEnumerable<int> EnterNumbersFromConsole()
        {
            var result = new Stack<int>();

            string line = Console.ReadLine().Trim();

            while (line != string.Empty)
            {
                int number = int.Parse(line);
                result.Push(number);
                line = Console.ReadLine().Trim();
            }

            return result;
        }

        public static void PrintStack(Stack<int> stack)
        {
            while (stack.Count > 0)
            {
                int currentNumber = stack.Pop();
                Console.Write("{0} ", currentNumber);
            }

            Console.WriteLine();
        }
    }
}
