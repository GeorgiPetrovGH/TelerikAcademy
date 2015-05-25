/*
Problem 6. binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

using System;
using System.Text;

class BinToHex
{
    private static string F;
    static void Main()
    {
        string numberBin = "10011010010";
        Console.WriteLine(FindHex(numberBin));
    }
    static string FindHex(string x)
    {

        StringBuilder result = new StringBuilder();        
        int len = x.Length;
        while (len >= 4) 
        {
            string temp = x.Substring(len - 4, 4);
            result.Insert(0, BinDigit(temp));
            x = x.Remove(len - 4);
            len = x.Length;
        }
        if (len > 0 && len < 4)
        {
            StringBuilder temp = new StringBuilder(x);
            for (int i = 0; i < 4-len; i++)
            {
                temp.Insert(0, "0"); 
            }
            result.Insert(0, BinDigit(temp.ToString()));
        }
        return result.ToString();
    }

    static string BinDigit(string x) 
    {
        string result = "";
        switch (x)
        {
            case "0000": result = "0"; break;
            case "0001": result = "1"; break;
            case "0010": result = "2"; break;
            case "0011": result = "3"; break;
            case "0100": result = "4"; break;
            case "0101": result = "5"; break;
            case "0110": result = "6"; break;
            case "0111": result = "7"; break;
            case "1000": result = "8"; break;
            case "1001": result = "9"; break;
            case "1010": result = "A"; break;
            case "1011": result = "B"; break;
            case "1100": result = "C"; break;
            case "1101": result = "D"; break;
            case "1110": result = "E"; break;
            case "1111": result = "F"; break;
        }
        return result;
    }
}

