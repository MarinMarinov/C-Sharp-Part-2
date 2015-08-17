/*
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:

    matrix	                result		      matrix	        result
ha	 fifi	ho	hi                           s	qq	s   
fo	 ha	    hi	xx        ha, ha, ha         pp	pp	s          s, s, s
xxx	 ho	    ha	xx                           pp	qq	s
                                                                                           
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter matrix dimension n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter matrix dimension m: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter matrix element [{0}{1}]= ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }


        /*string[,] matrix = new string[,]
        {
            {"ha","fifi","ho","hi"},
            {"fo","ha","hi","xx"},
            {"xxx","ho","ha","xx"}
        };
            {
                 {"s","qq","s"},
                 {"pp","pp","s"},
                 {"pp","qq","s"}
            };*/

        Console.WriteLine("You have entered the following matrix:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, -10}", matrix[row,col]);
            }
            Console.WriteLine();
        }
        string strings = "";
        int currentCount = 1;
        int count = 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++) 
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentCount++;
                }
                
                if (currentCount > count)
                {
                    count = currentCount;
                    strings = matrix[row, col];
                }
            }
            currentCount = 1;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0)-1; row++) 
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentCount++;
                }
                
                if (currentCount > count)
                {
                    count = currentCount;
                    strings = matrix[row, col];
                }
            }
            currentCount = 1;
        }

        for (int row = 0, col = 0; row < matrix.GetLength(0)-1 && col < matrix.GetLength(1)-1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                currentCount++;
            }
            
            if (currentCount > count)
            {
                count = currentCount;
                strings = matrix[row, col];
            }
        }
        Console.WriteLine();
        Console.WriteLine("The result is: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(i < count -1 ? "{0}, " : "{0}", strings);
        }
        Console.WriteLine();
    }
}