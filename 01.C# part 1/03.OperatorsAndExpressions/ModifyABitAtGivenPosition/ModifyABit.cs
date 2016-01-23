/*
Problem 14. Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p
from the binary representation of n while preserving all other bits in n.
*/

using System;
 class ModifyABit
    {
        static void Main()
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter Bit Position: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Enter Bit Value: ");
            int value = int.Parse(Console.ReadLine());
            int result = 0;

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            
            int mask = 1 << position;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> position;
            if (bit == 1) 
            {
                if (value == 0)
                {
                    int otherMask = ~(1 << position);
                    result = number & otherMask;
                }
                else 
                {
                    result = number;
                }
            }
            else 
            {
                if (value == 1)
                {
                    int otherMask = 1 << position;
                    result = number | otherMask;
                }
                else 
                {
                    result = number;
                }
            }
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine(result);
        }
    }
