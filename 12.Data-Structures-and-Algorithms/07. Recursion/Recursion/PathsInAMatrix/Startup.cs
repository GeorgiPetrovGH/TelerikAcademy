namespace PathsInAMatrix
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
            {' ', ' ', ' ', ' ', ' ', ' ', 'E'},
        };

        private static readonly int[] startPoint = new[] { 0, 0 };
        //private static readonly int[] endPoint = new[] { 4, 6 };

        private static List<string> path = new List<string>();

        public static void Main()
        {
            PrintPaths(startPoint[0], startPoint[1]);
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

        private static void PrintPaths(int row, int col)
        {
            if (!IsValidCell(row, col))
            {
                return;
            }

            if (matrix[row, col] == 'E')
            {
                path.Add("(" + row + ", " + col + ")");
                Console.WriteLine(string.Join(" -> ", path));
                path.RemoveAt(path.Count - 1);

                return;
            }

            matrix[row, col] = '*';
            path.Add("(" + row + ", " + col + ")");
            PrintPaths(row - 1, col);
            PrintPaths(row + 1, col);
            PrintPaths(row, col - 1);
            PrintPaths(row, col + 1);
            matrix[row, col] = ' ';
            path.RemoveAt(path.Count - 1);
        }
    }
}
