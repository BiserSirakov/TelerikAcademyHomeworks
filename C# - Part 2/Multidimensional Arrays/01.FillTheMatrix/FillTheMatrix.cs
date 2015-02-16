//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class FillTheMatrix
{
    private static void PrintMatrix(int[,] matrix, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    static int number = 1;

    static void Spiral(int[,] matrix, int row, int col, int n)
    {
        if (number >= n * n)
        {
            return;
        }
        else
        {
            // down
            while ((row < n) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                row++;
                number++;
            }
            row--;
            col++;
            // left
            while ((col < n) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                col++;
                number++;
            }
            col--;
            row--;
            // up
            while ((row >= 0) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                row--;
                number++;
            }
            row++;
            col--;
            // left
            while ((col > 0) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                col--;
                number++;
            }

            if (matrix[row, col] != 0)
            {
                row++;
                col++;
                Spiral(matrix, row, col, n);
            }
        }
    }

    static void DisplayArray(int[,] arr, int n)
    {
        for (int i = 0; i < Math.Sqrt(arr.Length); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < Math.Sqrt(arr.Length); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter N : ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        // a)
        Console.WriteLine("a)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + col * n + 1;
            }
        }
        PrintMatrix(matrix, n);

        // b)
        Console.WriteLine("\nb)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((col % 2) == 0)
                {
                    matrix[row, col] = row + 1 + (n * col);
                }
                else
                {
                    matrix[n - row - 1, col] = row + 1 + (n * col);
                }
            }
        }
        PrintMatrix(matrix, n);

        // c)
        Console.WriteLine("\nc)");
        int Row = n - 1, Col = 0, data = 0;
        for (int i = 0; i < n; i++)
        {
            do
            {
                data++;
                if (Row < 0) Row = 0;
                matrix[Row, Col] = data;
                Row++;
                Col++;
            } while (Row < n);

            Row -= Col + 1;
            Col = 0;
        }

        Row = 0;
        Col = 1;
        for (int i = 0; i < n - 1; i++)
        {
            do
            {
                data++;
                matrix[Row, Col] = data;
                Row++;
                Col++;
            } while (Col < n);

            Col -= Row - 1;
            Row = 0;
        }
        PrintMatrix(matrix, n);

        // d)
        Console.WriteLine("\nd)");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = 0;
            }
        }

        Spiral(matrix, 0, 0, n);
        PrintMatrix(matrix, n);
    }
}