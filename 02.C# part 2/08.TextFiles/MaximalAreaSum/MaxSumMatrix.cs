/*
Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
 */

using System;
using System.IO;
class MaxSumMatrix
{
    static void Main()
    {
        string file01 = @"..\..\file01.txt";        
        try
        {
            StreamReader reader01 = new StreamReader(file01);
            int number = int.Parse(reader01.ReadLine());
            string[,] matrix = new string[number, number];
            string line = reader01.ReadLine();
            for (int i = 0; i < number; i++)
            {
                string[] lineArr = line.Split(' ');
                for (int j = 0; j < number; j++)
                {
                    matrix[i, j] = lineArr[j];
                }
                line = reader01.ReadLine();
            }
            PrintMatrix(matrix, number);
            Console.WriteLine("Max sum matrix[2,2] = {0}",FindMaxSym(matrix,number));

        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }

    static void PrintMatrix(string[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
		{
			 for (int j = 0; j < n; j++)
			{
			 Console.Write("{0} ",matrix[i,j]);
			}
            Console.WriteLine();
		}
    }

    static int FindMaxSym(string[,] matrix, int n) 
    {
        int result = 0;
        int temp = 0;
        for (int i = 0; i < n-1; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                temp = int.Parse(matrix[i, j]) + int.Parse(matrix[i, j + 1]) + int.Parse(matrix[i + 1, j]) + int.Parse(matrix[i + 1, j + 1]);
                if (temp > result) 
                {
                    result = temp;
                }
            }            
        }
        return result;
    }
}

