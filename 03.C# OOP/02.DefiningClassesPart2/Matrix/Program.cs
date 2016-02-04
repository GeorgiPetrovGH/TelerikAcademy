using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 3);
            Matrix<int> secondMatrix = new Matrix<int>(3, 3);
            FillMatrix(firstMatrix);
            FillMatrix(secondMatrix);
            Console.WriteLine("First matrix:");
            PrintMatrix(firstMatrix);
            Console.WriteLine("Second matrix:");
            PrintMatrix(secondMatrix);
            Console.WriteLine("Operation +");
            PrintMatrix(firstMatrix + secondMatrix);
            Console.WriteLine("Operation -");
            PrintMatrix(firstMatrix - secondMatrix);
            Console.WriteLine("Operation *");
            PrintMatrix(firstMatrix * secondMatrix);

        }

        static void FillMatrix(Matrix<int> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix[i, j] = i + j;
                }
            }
        }

        static void PrintMatrix(Matrix<int> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    Console.Write("{0} ", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }

    
}
