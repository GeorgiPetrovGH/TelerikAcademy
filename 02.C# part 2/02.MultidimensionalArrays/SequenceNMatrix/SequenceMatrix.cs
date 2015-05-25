/*
Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
*/

using System;
class SequenceMatrix
{
    static string[,] matrix01 = { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };
    static string[,] matrix02 = { { "s", "qq", "s" }, { "pp", "pp", "s", }, { "pp", "qq", "s", } };
    static void Main()
    {
        string maxText = "";
        int maxCount = 0;

        Console.WriteLine("matrix01:");
        for (int row = 0; row < matrix01.GetLength(0); row++)
        {
            for (int col = 0; col < matrix01.GetLength(1); col++)
            {
                int tempCount = 0;
                
                tempCount = maxRow(matrix01, row, col);
                if (maxCount < tempCount) 
                {
                    maxCount = tempCount;
                    maxText = matrix01[row, col];
                }

                tempCount = maxCol(matrix01, row, col);
                if (maxCount < tempCount)
                {
                    maxCount = tempCount;
                    maxText = matrix01[row, col];
                }

                tempCount = maxDiagonal(matrix01, row, col);
                if (maxCount < tempCount)
                {
                    maxCount = tempCount;
                    maxText = matrix01[row, col];
                }

            }
        }
        Console.WriteLine("Count = {0}", maxCount);
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write("{0} ", maxText);
        }
        Console.WriteLine();


        Console.WriteLine();
        maxText = "";
        maxCount = 0;

        Console.WriteLine("matrix02:");
        for (int row = 0; row < matrix02.GetLength(0); row++)
        {
            for (int col = 0; col < matrix02.GetLength(1); col++)
            {
                int tempCount = 0;

                tempCount = maxRow(matrix02, row, col);
                if (maxCount < tempCount)
                {
                    maxCount = tempCount;
                    maxText = matrix02[row, col];
                }

                tempCount = maxCol(matrix02, row, col);
                if (maxCount < tempCount)
                {
                    maxCount = tempCount;
                    maxText = matrix02[row, col];
                }

                tempCount = maxDiagonal(matrix02, row, col);
                if (maxCount < tempCount)
                {
                    maxCount = tempCount;
                    maxText = matrix02[row, col];
                }

            }
        }
        Console.WriteLine("Count = {0}", maxCount);
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write("{0} ", maxText);
        }
        Console.WriteLine();


    }

    static int maxRow(string[,] array, int row, int col)
    {
        int colLen = array.GetLength(1);
        int pos = col;
        int count = 1;
        bool sequence = true;
        while (sequence && pos < colLen - 1)
        {
            if (string.Equals(array[row, pos], array[row, pos + 1]))
            {
                count++;
                pos++;
            }
            else
            {
                sequence = false;
            }
        }
        return count;
    }

    static int maxCol(string[,] array, int row, int col)
    {
        int rowLen = array.GetLength(0);
        int pos = row;
        int count = 1;
        bool sequence = true;
        while (sequence && pos < rowLen - 1)
        {
            if (string.Equals(array[pos, col], array[pos + 1, col]))
            {
                count++;
                pos++;
            }
            else
            {
                sequence = false;
            }
        }
        return count;
    }

    static int maxDiagonal(string[,] array, int row, int col)
    {
        int colLen = array.GetLength(1);
        int rowLen = array.GetLength(0);
        int posCol = col;
        int posRow = row;
        int count = 1;
        bool sequence = true;
        while (sequence && (posCol < colLen - 1) && (posRow < rowLen - 1))
        {
            if (string.Equals(array[posRow, posCol], array[posRow + 1, posCol + 1]))
            {
                count++;
                posCol++;
                posRow++;
            }
            else
            {
                sequence = false;
            }
        }
        return count;
    }   

}

