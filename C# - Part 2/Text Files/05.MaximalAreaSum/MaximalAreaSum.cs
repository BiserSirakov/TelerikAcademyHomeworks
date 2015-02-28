//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.

using System;
using System.IO;
using System.Linq;

class MaximalAreaSum
{
    static void Main()
    {
        string firstFile = @"D:\New Text Document.txt";
        string secondFile = @"D:\New Text Document (2).txt";

        StreamReader reader = new StreamReader(firstFile);

        int size = int.Parse(reader.ReadLine());
        int[,] matrix = new int[size, size];

        FillMatrix(reader, matrix);

        int result = GetMaxArea(matrix);

        File.WriteAllText(secondFile, result.ToString());
    }

    static void FillMatrix(StreamReader reader, int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] currentLineNumbers = reader.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = currentLineNumbers[col];
            }
        }
    }

    static int GetMaxArea(int[,] matrix)
    {
        int maxValue = 0;
        int tempValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                tempValue = 0;

                for (int checkRow = 0; checkRow < 2; checkRow++)
                {
                    for (int checkCol = 0; checkCol < 2; checkCol++)
                    {
                        tempValue += matrix[row + checkRow, col + checkCol];
                    }
                }

                maxValue = Math.Max(maxValue, tempValue);
            }
        }
        return maxValue;
    }
}