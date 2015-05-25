/*
Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 */

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 : Int");
        Console.WriteLine("2 : Double");
        Console.WriteLine("3 : String");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice) 
        {
            case 1:
                {
                    Console.Write("Enter integer number: ");
                    int number = int.Parse(Console.ReadLine());
                    number += 1;
                    Console.WriteLine(number);
                    break;
                }
            case 2:
                {
                    Console.Write("Enter double number: ");
                    double number = double.Parse(Console.ReadLine());
                    number += 1;
                    Console.WriteLine(number);
                    break;
                }
            case 3:
                {
                    Console.Write("Enter string: ");
                    string text = Console.ReadLine();
                    text += "*";
                    Console.WriteLine(text);
                    break;
                }
        }
    }
}

