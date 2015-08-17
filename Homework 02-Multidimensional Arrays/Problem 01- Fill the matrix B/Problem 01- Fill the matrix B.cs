﻿//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
/* 1  8  9   16
   2  7  10  15
   3  6  11  14
   4  5  12  13
 */


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter matrix dimension n: ");
        int matrixDimension = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixDimension, matrixDimension];
        int counter = 1;
        int currentCounter = 1;

        for (int col = 0; col < matrixDimension; col++)
        {
            for (int row = 0; row < matrixDimension; row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = counter++;
                }
                else
                {
                    matrix[row, col] = --counter;
                }
            }
            if (col % 2 == 0)
            {
                currentCounter = counter;
                currentCounter += matrixDimension;
                counter = currentCounter;
            }
            else
            {
                counter = currentCounter;
            }
        }
        for (int row = 0; row < matrixDimension; row++)
        {
            for (int col = 0; col < matrixDimension; col++)
            {
                Console.Write("{0, -5}", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}