/*
Problem 1. Fill the size

Write a program that fills and prints a size of size (n, n) as shown below:
*/

using System;
class FillMatrix
{
    static int size = 5;    
    static void printArray(int[,] array)
    {
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0} ", Convert.ToString(array[row, col]).PadLeft(2));
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] array = new int[size, size];
        int row = new int();
        int col = new int();
        
        //first matrix
        int value = 1;
        for (col = 0; col < size; col++)
        {
            for (row = 0; row < size; row++)
            {
                array[row, col] = value;
                value++;
            }
        }
        printArray(array);
        Console.WriteLine();

        //second matrix
        value = 1;
        for (col = 0; col < size; col++)
        {
            if (col % 2 == 0)
            {
                for (row = 0; row < size; row++)
                {
                    array[row, col] = value;
                    value++;
                }
            }
            else
            {
                for (row = size - 1; row >= 0; row--)
                {
                    array[row, col] = value;
                    value++;
                }
            }
        }
        printArray(array);
        Console.WriteLine();

        //third matrix
        value = 1;        
        for (row = size - 1; row >= 0; row--)
        {
            for (col = 0; row + col < size; col++)
            {
                array[row + col, col] = value++;
            }
        }

        for (col = 1; col < size; col++)
        {
            for (row = 0; row + col < size; row++)
            {
                array[row, row + col] = value++;
            }
        }   
        printArray(array);
        Console.WriteLine();

        //fourth matrix        
        int[,] matrix = new int[size, size];
        value = 1;
        row = 0;
        col = 0;
        
        while (value <= size * size) 
        {            
            while (row < size && matrix[row, col] == 0) 
            {
                matrix[row, col] = value++;
                row++;
            }
            row--;
            col++;
            
            while (col < size && matrix[row, col] == 0) 
            {
                matrix[row, col] = value++;
                col++;
            }
            col--;
            row--;

            while (row >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col] = value++;
                row--;
            }
            row++;
            col--;
            

            while (col >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col] = value++;
                col--;
            }
            col++;
            row++;            
        }
        printArray(matrix);
        Console.WriteLine();

    }
}

