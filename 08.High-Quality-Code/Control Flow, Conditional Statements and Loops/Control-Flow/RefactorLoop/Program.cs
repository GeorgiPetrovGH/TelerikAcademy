namespace RefactorLoop
{
    using System;
    class Program
    {
        static void Main()
        {
            /*
                int i=0;
                for (i = 0; i < 100;)
                {
                    if (i % 10 == 0)
                    {
                        Console.WriteLine(array[i]);
                        if ( array[i] == expectedValue )
                        {
                            i = 666;
                        }
                        i++;
                    }
                    else
                    {
                    Console.WriteLine(array[i]);
                    i++;
                    }
                }
                // More code here
                if (i == 666)
                {
                    Console.WriteLine("Value Found");
                }
             */


        }

        public void PrintValue(int[] numbers, int expectedValue)
        {
            int len = numbers.Length;
            bool isNumberFound = false;

            for (int i = 0; i < len; i++)
            {
                if (i % 10 == 0 && numbers[i] == expectedValue)
                {
                    isNumberFound = true; 
                }

                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();

            if (isNumberFound)
            {
                Console.WriteLine("Value found");
            }
        }
    }
}
