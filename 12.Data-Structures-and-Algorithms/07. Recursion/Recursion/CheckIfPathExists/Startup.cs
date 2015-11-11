namespace CheckIfPathExists
{
    using System;    

    public class Startup
    {
        private static readonly int[,] matrix = new int[100, 100];
        private static bool isPathFound = false;

        private static readonly int[] startPoint = new[] { 0, 0 };
        //private static readonly int[] endPoint = new[] { 50, 50 };

        public static void Main()
        {
            matrix[50, 50] = 1;            
            CheckPaths(startPoint[0], startPoint[1]);
            Console.WriteLine(isPathFound);
        }

        private static bool ValidCell(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0)
                || col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            if (matrix[row, col] == 2)
            {
                return false;
            }

            return true;
        }

        private static void CheckPaths(int row, int col)
        {
            if (isPathFound == true)
            {
                return;
            }
            if (!ValidCell(row, col))
            {
                return;
            }

            if (matrix[row, col] == 1)
            {
                isPathFound = true;
                return;
            }

            matrix[row, col] = 2;
            CheckPaths(row - 1, col);
            CheckPaths(row + 1, col);
            CheckPaths(row, col - 1);
            CheckPaths(row, col + 1);
            //matrix[row, col] = 0;
        }
    }
}
