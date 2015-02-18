using System;

class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols) // konstruktor
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);

        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }

        return result;
    }

    public static Matrix operator -(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);

        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        int temp;

        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                temp = 0;
                for (int i = 0; i < first.Columns; i++)
                {
                    temp += first[row, i] * second[i, col];
                }
                result[row, col] = temp;
            }
        }

        return result;
    }

    public int this[int row, int col] // indeksator
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        string result = null;

        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Columns; j++)
            {
                result += matrix[i, j] + " ";
            }
            result += Environment.NewLine;
        }

        return result;
    }
}