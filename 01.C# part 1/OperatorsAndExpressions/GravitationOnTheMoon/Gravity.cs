/*
Problem 2. Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/

using System;

class Gravity
{
    static void Main()
    {
        Console.Write("Enter Weigth on Earth: ");
        double weigth = double.Parse(Console.ReadLine());        
        Console.WriteLine("Weigth on Moon is: " + (0.17 * weigth));
    }
}
