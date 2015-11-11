namespace LargestArea
{
    using System;
    using System.Collections.Generic;    

    public class Startup
    {
        private static readonly char[,] matrix =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        };

        private static readonly int[] startPoint = new[] { 0, 0 };

        public static void Main()
        {
            var bestLength = FindLargestConnectedArea();

            Console.WriteLine(bestLength);
        }

        private static bool IsValidCell(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0)
                || col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            if (matrix[row, col] == '*')
            {
                return false;
            }

            return true;
        }

        private static void FindArea(int row, int col, ref int currentLength)
        {
            if (!IsValidCell(row, col))
            {
                return;
            }

            currentLength++;
            matrix[row, col] = '*';

            FindArea(row - 1, col, ref currentLength);
            FindArea(row + 1, col, ref currentLength);
            FindArea(row, col - 1, ref currentLength);
            FindArea(row, col + 1, ref currentLength);            
        }

        private static int FindLargestConnectedArea()
        {
            int bestLength = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var currentLength = 0;

                    FindArea(i, j, ref currentLength);

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                    }
                }
            }

            return bestLength;
        }
    }
}
