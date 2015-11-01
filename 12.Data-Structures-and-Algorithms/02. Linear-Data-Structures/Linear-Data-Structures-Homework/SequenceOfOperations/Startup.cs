namespace SequenceOfOperations
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            int start = 5;
            int end = 16;

            var stack = new Stack<int>();
            
            while (start <= end)
            {
                stack.Push(end);

                if (end / 2 >= start)
                {
                    if (end % 2 == 0)
                    {
                        end /= 2;
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    if (end - 2 >= start)
                    {
                        end -= 2;
                    }
                    else
                    {
                        end--;
                    }
                }
            }

            Console.WriteLine(string.Join(" -> ", stack));
        }
    }
}
