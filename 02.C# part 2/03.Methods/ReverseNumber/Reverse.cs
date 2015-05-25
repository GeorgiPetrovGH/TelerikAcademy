/*
Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
*/

using System;
class Reverse
{
    static void Main()
    {
        int number = 12345;
        Console.WriteLine("Number is: {0}", number);
        Console.WriteLine("Reversed number is: {0}", findReversedNumber(number));        
    }

    static int findReversedNumber(int x)
    {        
        if (x < 0) 
        {
            return -1;
        }
        else 
        {
            int number = x;
            int reversed = 0;
            while (number > 0) 
            {
                reversed = (10 * reversed) + (number % 10);
                number /= 10;
            }
            return reversed;
        }
    }
}

