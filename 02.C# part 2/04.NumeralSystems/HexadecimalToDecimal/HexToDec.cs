/*
Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
 */

using System;
class HexToDec
{
    static void Main()
    {
        string numberHex = "1C8";
        Console.WriteLine(findDec(numberHex));
    }

    static int findDec(string number)
    {
        int result = 0;
        int cnt = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            char item = number[i];
            switch (item)
            {
                case '0': result += 0 * cnt; break;
                case '1': result += 1 * cnt; break;
                case '2': result += 2 * cnt; break;
                case '3': result += 3 * cnt; break;
                case '4': result += 4 * cnt; break;
                case '5': result += 5 * cnt; break;
                case '6': result += 6 * cnt; break;
                case '7': result += 7 * cnt; break;
                case '8': result += 8 * cnt; break;
                case '9': result += 9 * cnt; break;
                case 'A': result += 10 * cnt; break;
                case 'B': result += 11 * cnt; break;
                case 'C': result += 12 * cnt; break;
                case 'D': result += 13 * cnt; break;
                case 'E': result += 14 * cnt; break;
                case 'F': result += 15 * cnt; break;
            }
            cnt *= 16;
        }
        return result;
    }
}

