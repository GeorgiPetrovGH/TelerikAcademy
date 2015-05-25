/*
Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
*/

using System;
class SayHelloMethod
{
    static void Main()
    {
        sayHello();
    }

    static void sayHello() 
    {
        Console.WriteLine("Enter Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}

