using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T> where T : IComparable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (value > 0)
                {
                    this.rows = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Rows can not be less than zero.");
                }
            }
        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value > 0)
                {
                    this.cols = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Cols can not be less than zero.");
                }
            }
        }



        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }
                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Addition not possible on matrixes with different number of rows and cols.");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Substraction not possible on matrixes with different number of rows and cols.");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Rows)
            {
                throw new Exception("The matrixes cannot be multiplied.");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            T temp;
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    temp = (dynamic)0;
                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += (dynamic)matrix1[i, index] * matrix2[index, j];
                    }
                    result[i, j] = (dynamic)temp;
                }
            }
            return result;
        }

        private static bool OverrideBool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                        return true;
                }
            }
            return false;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }
        public static bool operator false(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }




    }
}
