/*
Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
 */

using System;
class DecToHex
{
    static void Main()
    {
        int numberDec = 1234;
        Console.WriteLine(FindHex(numberDec));        
    }

    static string FindHex(int x)
    {
        string result = "";
        int temp = 0;
        while (x > 0) 
        {
            temp = x % 16;
            if (temp >= 10) 
            {
                switch(temp)
                {
                    case 10: result += "A"; break;
                    case 11: result += "B"; break;
                    case 12: result += "C"; break;
                    case 13: result += "D"; break;
                    case 14: result += "E"; break;
                    case 15: result += "F"; break;
                }
            }
            else { result += temp; }            
            x /= 16;
        }
        char[] array = result.ToCharArray(); 
        Array.Reverse(array);
        result = new string(array);
        return result;
    }
}

