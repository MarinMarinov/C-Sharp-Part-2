﻿//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
/* 1 5 9 13
   2 6 10 14
   3 7 11 16
   4 8 12 16
 */


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter matrix dimension: ");
        int matrixDimension = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixDimension, matrixDimension];
        int counter = 1;
        for (int col = 0; col < matrixDimension; col++)
        {
            for (int row = 0; row < matrixDimension; row++)
            {
                matrix[row, col] = counter++;
            }
        }
        for (int row = 0; row < matrixDimension; row++)
        {
            for (int col = 0; col < matrixDimension; col++)
            {
                Console.Write("{0, -4}", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}
