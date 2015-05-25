/*
Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
*/

using System;
class LastDigit
{

    static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
    static void Main()
    {
        int a = 15678;
        Console.WriteLine("numbers is: {0}", a);
        Console.Write("Last digit is: ");
        PrintDigit(a);        
        Console.Write("Last digit is: ");
        PrintDigitVar(a);
        
        
    }

    //first variant
    static void PrintDigit(int x) 
    {
        switch (x%10) 
        {
            case 0: Console.WriteLine("zero");break;
            case 1: Console.WriteLine("one");break;
            case 2: Console.WriteLine("two");break;
            case 3: Console.WriteLine("three");break;
            case 4: Console.WriteLine("four");break;
            case 5: Console.WriteLine("five");break;
            case 6: Console.WriteLine("six");break;
            case 7: Console.WriteLine("seven");break;
            case 8: Console.WriteLine("eight");break;
            case 9: Console.WriteLine("nine");break;            
        }
    }

    //second variant
    static void PrintDigitVar(int x) 
    {
        Console.WriteLine(digits[x%10]);
    }
}

