﻿//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

/* 7  11  14  16
   4  8   12  15 
   2  5   9   13
   1  3   6   10
 */


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter matrix dimension n: ");
        int matrixDimension = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixDimension, matrixDimension];
        int rows = 0;
        int cols = 0;
        int value = 1;

        for (int i = matrixDimension-1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < matrixDimension && cols<matrixDimension) // inserting element values under the main matrix diagonal 
            {
                matrix[rows, cols] = value;
                rows++;
                cols++;
                value++;
                
            }
        }
        for (int i = 1; i < matrixDimension; i++)
        {
            rows = i;
            cols = 0;
            while (rows < matrixDimension && cols < matrixDimension)
            {
                matrix[cols, rows] = value;
                cols++;
                rows++;
                value++;
            }
        }
        for (rows = 0; rows < matrixDimension; rows++)
        {
            for (cols = 0; cols < matrixDimension; cols++)
            {
                Console.Write("{0, -5}", matrix[rows,cols]);
            }
            Console.WriteLine();
        }
    }
}
