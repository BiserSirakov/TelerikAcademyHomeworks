//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, 
//column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter M = ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Matrix[{0},{1}] = ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        int numMaxElements = 0;
        int numCurrElements = 0;
        string maxStr = "";

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                numCurrElements = 0;
                for (int k = i; k < n - 1; k++)
                {
                    if (matrix[j, k + 1] == matrix[j, k])
                    {
                        numCurrElements++;
                    }

                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = matrix[j, k];
                    }
                }

                numCurrElements = 0;
                for (int k = j; k < m - 1; k++)
                {
                    if (matrix[k, i] == matrix[k + 1, i])
                    {
                        numCurrElements++;
                    }

                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = matrix[k, i];
                    }
                }

                numCurrElements = 0;
                for (int k = i, l = j; (k < n - 1) && (l < m - 1); k++, l++)
                {
                    if (matrix[l, k] == matrix[l + 1, k + 1])
                    {
                        numCurrElements++;
                    }

                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = matrix[l, k];
                    }
                }
            }
        }

        for (int i = 0; i < numMaxElements + 1; i++)
        {
            Console.Write(maxStr + ", ");
        }
        Console.WriteLine();
    }
}