/*
Problem 11.* Number as Words

Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
 */

using System;
class Numbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int one = number % 10;
        int ten = (number / 10) % 10;
        int hundred = number / 100;

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid input.");
        }
        else
        {
            switch (hundred)
            {
                case 1: Console.Write("one hundred"); break;
                case 2: Console.Write("two hundred"); break;
                case 3: Console.Write("three hundred"); break;
                case 4: Console.Write("four hundred"); break;
                case 5: Console.Write("five hundred"); break;
                case 6: Console.Write("six hundred"); break;
                case 7: Console.Write("seven hundred"); break;
                case 8: Console.Write("eight hundred"); break;
                case 9: Console.Write("nine hundred"); break;
            }

            if ((hundred >= 1 && hundred <= 9) && (ten != 0 || one != 0)) 
            {
                Console.Write(" and ");
            }

            if (ten == 1)
            {
                switch (one)
                {
                    case 0: Console.Write("ten"); break;
                    case 1: Console.Write("eleven"); break;
                    case 2: Console.Write("twelve"); break;
                    case 3: Console.Write("thirteen"); break;
                    case 4: Console.Write("fourtheen"); break;
                    case 5: Console.Write("fifteen"); break;
                    case 6: Console.Write("sixteen"); break;
                    case 7: Console.Write("seventeen"); break;
                    case 8: Console.Write("eighteen"); break;
                    case 9: Console.Write("nineteen"); break;
                }
            }
            else
            {
                switch (ten)
                {
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("fourty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                }

                switch (one)
                {
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;
                }
            }

        }
        Console.WriteLine();
    }
}

