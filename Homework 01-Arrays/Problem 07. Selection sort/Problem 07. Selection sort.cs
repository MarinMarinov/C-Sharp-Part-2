/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
and find the smallest from the rest, move it at the second position, etc.*/


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Insert array dimension: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Insert array element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize-1; i++)
        {
            for (int j = i+1; j < arraySize; j++)
            {
                if (array[i] > array[j])
                {
                    int temporaryNumber = array[i];
                    array[i] = array[j];
                    array[j] = temporaryNumber;
                }
            }
        }

        Console.WriteLine("Sorted array is:");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}