/*
Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */

using System;
class XToYSystem
{
    static void Main()
    {
        string myBin = "10011010010";        
        string myHex = DecToX(XtoDec(myBin, 2), 16);
        Console.WriteLine(myHex);        
        
    }

    static string DecToX(int x, int s) 
    {
        string result = null;
        int number = x;
        int temp = 0;
        while (number > 0) 
        {
            temp = number % s;
            result += DecToString(temp);
            number /= s;
        }
        char[] array = result.ToCharArray();
        Array.Reverse(array);
        result = new string(array);
        return result;
    }

    static string DecToString(int x) 
    {
        string result = null;
        if (x >= 0 && x <= 9) 
        {
            result = Convert.ToString(x);
            return result;
        }
        switch (x) 
        {
            case 10: result = "A"; break;
            case 11: result = "B"; break;
            case 12: result = "C"; break;
            case 13: result = "D"; break;
            case 14: result = "E"; break;
            case 15: result = "F"; break;
        }
        return result;
    }
    static int XtoDec(string x, int s)
    {
        int result = 0;
        int cnt = 1;
        for (int i = x.Length - 1; i >= 0; i--)
        {
            result += CharToDec(x[i]) * cnt;
            cnt *= s;
        }
        return result;
    }

    static int CharToDec(char x)
    {
        int result = 0;
        if (x >= '1' && x <= '9')
        {
            result = x - '0';
        }
        else if (x >= 'A' && x <= 'F')
        {
            result = x - 'A' + 10;
        }
        return result;
    }
}

