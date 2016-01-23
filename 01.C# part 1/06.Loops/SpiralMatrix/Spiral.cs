/*
Problem 19.** Spiral Matrix

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
 */

using System;
class Spiral
{
    static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 20)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                int[,] array = new int[n, n];
                int count = 1;
                int row = 0;
                int col = 0;
                while(count <= n * n)
                {
                    while(col < n && array[row, col] == 0)
                    {
                        array[row,col] = count;
                        col++;
                        count++;
                    }
                    col--;
                    row++;
                    while (row < n && array[row, col] == 0)
                    {
                        array[row, col] = count;
                        row++;
                        count++;
                    }
                    row--;
                    col--;
                    while (col >= 0 && array[row, col] == 0)
                    {
                        array[row, col] = count;
                        col--;
                        count++;
                    }
                    col++;
                    row--;
                    while (row >= 0 && array[row, col] == 0)
                    {
                        array[row, col] = count;
                        row--;
                        count++;
                    }
                    row++;
                    col++;

                }
                for (int i = 0; i < n; i++)
			    {
			        for (int j = 0; j < n; j++)
			        {
			            Console.Write("{0} ", Convert.ToString(array[i, j]).PadLeft(2));
			        }
                    Console.WriteLine();
			    }
                
            }
        }
}

