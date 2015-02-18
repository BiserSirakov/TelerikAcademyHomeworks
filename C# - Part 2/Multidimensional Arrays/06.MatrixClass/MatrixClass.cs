//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, 
//indexer for accessing the matrix content and ToString().

using System;

class MatrixClass
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 0] = 1;
        matrix1[0, 1] = 50;
        matrix1[1, 0] = 36;
        matrix1[1, 1] = -12;
        Console.WriteLine("The first matrix is : ");
        Console.WriteLine(matrix1.ToString());

        Matrix matrix2 = new Matrix(2, 2);
        matrix2[0, 0] = 2;
        matrix2[0, 1] = -4;
        matrix2[1, 0] = 72;
        matrix2[1, 1] = 24;
        Console.WriteLine("The second matrix is : ");
        Console.WriteLine(matrix2.ToString());

        Matrix sum = matrix1 + matrix2;
        Console.WriteLine("Their sum is : ");
        Console.WriteLine(sum.ToString());

        Matrix difference = matrix1 - matrix2;
        Console.WriteLine("Their difference is : ");
        Console.WriteLine(difference.ToString());

        Matrix product = matrix1 * matrix2;
        Console.WriteLine("Their product is : ");
        Console.WriteLine(product.ToString());
    }
}