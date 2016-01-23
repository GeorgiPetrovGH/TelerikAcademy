/*
Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
*/

using System;
class Digits
{
    static void Main()
    {
        Console.Write("Enter Four-Digit Number: ");
        int number = int.Parse(Console.ReadLine());
        
        int d = number % 10;
        number /= 10;
        int c = number % 10;
        number /= 10;
        int b = number % 10;
        int a = number / 10;
        
        Console.WriteLine(a + b + c + d);
        //Console.WriteLine(d * 1000 + c * 100 + b * 10 + a);
        //Console.WriteLine(d * 1000 + a * 100 + b * 10 + c);
        //Console.WriteLine(a * 1000 + c * 100 + b * 10 + d);        

        string firstResult = d.ToString() + c.ToString() + b.ToString() + a.ToString();
        string secondResult = d.ToString() + a.ToString() + b.ToString() + c.ToString();
        string thirdResult = a.ToString() + c.ToString() + b.ToString() + d.ToString();
        Console.WriteLine(firstResult);
        Console.WriteLine(secondResult);
        Console.WriteLine(thirdResult);
    }
}

