/*
Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;
class ReadNumbers
{
    static void Main()
    {
        int start = 0;
        int end = 100;
        ReadNumber(start, end);
    }

    static void ReadNumber(int start, int end)
    {
        int number = 0;
        int temp = 0;
        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (number < temp) 
                {
                    throw new IndexOutOfRangeException();
                }
                else 
                {
                    temp = number;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number is out of range.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid order.");
        }
    }


}

