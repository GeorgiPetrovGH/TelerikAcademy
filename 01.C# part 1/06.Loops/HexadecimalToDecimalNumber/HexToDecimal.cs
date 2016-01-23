/*
Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
 */

using System;
class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter number in hex: ");
        string hexNumber = Console.ReadLine();
        long decimalNumber = 0;
        long index = 1;

        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {

            long number = new long();
            if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
            {
                number = hexNumber[i] - '0';
            }
            else 
            {
                switch (hexNumber[i]) 
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                }
            }            
            decimalNumber += number * index;
            index *= 16;
        }
        Console.WriteLine(decimalNumber);

    }
}

