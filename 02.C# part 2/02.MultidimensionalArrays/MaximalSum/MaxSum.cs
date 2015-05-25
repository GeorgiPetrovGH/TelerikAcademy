/*
Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;
class MaxSum
{
    static int[,] matrix = { { 1, 2, 3, 4, 5 }, {5, -4, 3, -2, 1 }, { 5, -6, 7, -8, 9 }, { 9, 8, 7, 6, 5 }};
    static void Main()
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        
        int maxSum = int.MinValue;
        int maxRow = new int();
        int maxCol = new int();
       
        for (int row = 1; row < n-1; row++)
        {
            for (int col = 1; col < m-1; col++)
            {
                int sum = 0;
                sum += findSum(row, col);
                if (sum > maxSum) 
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }
        Console.WriteLine("Max sum = {0}", maxSum);
        printSquare(maxRow, maxCol);
        
    }

    static int findSum(int x, int y) 
    {
        int sum = 0;
        sum += matrix[x - 1, y - 1] + matrix[x - 1, y] + matrix[x - 1, y + 1] +
               matrix[x, y - 1] + matrix[x, y] + matrix[x, y + 1] +
               matrix[x + 1, y - 1] + matrix[x + 1, y] + matrix[x + 1, y + 1];
        return sum;
    }

    static void printSquare(int x, int y) 
    {
        for (int row = x-1; row <= x+1; row++)
        {
            for (int col = y-1; col <= y+1; col++)
            {
                Console.Write(Convert.ToString(matrix[row, col]).PadLeft(3));
            }
            Console.WriteLine();
        }
    }
}

