namespace Matrix
{
    using System;

    public class Matrix<T>
    {
        private readonly T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
                {
                    throw new ArgumentOutOfRangeException("Index out of range !");
                }

                return this.matrix[row, col];
            }
            private set
            {
                if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
                {
                    throw new ArgumentOutOfRangeException("Index out of range !");
                }

                this.matrix[row, col] = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The columns must be 1 or more !");
                }

                this.cols = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The rows must be 1 or more !");
                }

                this.rows = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentException("The matrices have different dimensions !");
            }

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = (dynamic)a[i, j] + b[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentException("The matrices have different dimensions !");
            }

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = (dynamic)a[i, j] - b[i, j];
                }
            }

            return result;
        }

        public static bool OverrideBool(Matrix<T> a)
        {
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    if (a[i,j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator true(Matrix<T> a)
        {
            return OverrideBool(a);
        }

        public static bool operator false(Matrix<T> a)
        {
            return OverrideBool(a);
        }
    }
}
