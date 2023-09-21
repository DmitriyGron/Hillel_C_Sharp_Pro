using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_4_2
{
    class Matrix
    {
        private int rows;
        private int columns;
        private double[,] data;

        public int Rows
        {
            get { return rows; }
        }

        public int Columns
        {
            get { return columns; }
        }

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new double[rows, columns];
        }

        public double this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new ArgumentException("Матриці повинні мати однакові розміри для додавання.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new ArgumentException("Матриці повинні мати однакові розміри для додавання.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix, double scalar)
        {
            Matrix result = new Matrix(matrix.Rows, matrix.Columns);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
                throw new ArgumentException("Кількість стовпців у першій матриці має збігатися з кількістю рядків у другій матриці.");

            Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Columns; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        public bool Equals(Matrix other)
        {
            if (other == null) return false;
            if (this.Rows != other.Rows || this.Columns != other.Columns)
                return false;

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    if (this[i, j] != other[i, j])
                        return false;
                }
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals(obj as Matrix);
        }

        public override int GetHashCode()
        {
            return data.GetHashCode();
        }

        public static bool operator ==(Matrix first, Matrix second)
        {
            if (ReferenceEquals(first, second))
                return true;
            if ((object)first == null || (object)second == null)
                return false;
            return first.Equals(second);
        }

        public static bool operator !=(Matrix first, Matrix second)
        {
            return !(first == second);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result += data[i, j] + " ";
                }
                result += Environment.NewLine;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;

            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;

            Matrix additionResult = matrix1 + matrix2;
            Matrix subtractionResult = matrix1 - matrix2;
            Matrix scalarMultiplicationResult = matrix1 * 2;
            Matrix matrixMultiplicationResult = matrix1 * matrix2;

            Console.WriteLine("Масив 1:");
            Console.WriteLine(matrix1);

            Console.WriteLine("Масив 2:");
            Console.WriteLine(matrix2);

            Console.WriteLine("Додавання:");
            Console.WriteLine(additionResult);

            Console.WriteLine("Віднімання:");
            Console.WriteLine(subtractionResult);

            Console.WriteLine("Множення на 2:");
            Console.WriteLine(scalarMultiplicationResult);

            Console.WriteLine("Множення масива на масив:");
            Console.WriteLine(matrixMultiplicationResult);

            Console.WriteLine("Масив 1 дорівнює Масив 2: " + (matrix1 == matrix2));
        }
    }
}
