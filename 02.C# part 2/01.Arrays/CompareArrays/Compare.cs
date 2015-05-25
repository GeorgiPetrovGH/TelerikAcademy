/*
Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
*/
using System;

class Compare
{
    static void Main()
    {
        int[] array01 = new int[5];
        int[] array02 = new int[5];
        bool arr = true;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("array01[{0}] = ", i);
            array01[i] = int.Parse(Console.ReadLine());
            Console.Write("array02[{0}] = ", i);
            array02[i] = int.Parse(Console.ReadLine());
            if (array01[i] >= array02[i])
            {
                Console.WriteLine("{0} >= {1}", array01[i], array02[i]);
            }
            else 
            {
                Console.WriteLine("{0} < {1}", array01[i], array02[i]);
                if (arr == true) { arr = false; };
            }

        }
        if(arr)
        {
            Console.WriteLine("array01 >= array02");
        }
        else
        {
            Console.WriteLine("array01 < array02");
        }
    }
}

