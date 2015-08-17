/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
 Example:   input	                                result
            2, 1, 1, 2, 3, 3, 2, 2, 2, 1	        2, 2, 2
 
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insert the size of the array = ");
        int arraySize = int.Parse(Console.ReadLine());

        int bestSequence = 1;
        int currentSequence = 1;
        int bestSequenceNumber = 0;
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Insert the array element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize-1; i++)
        {
            if (array[i] == array[i+1])
            {
                currentSequence++;
            }
            else
            {
                currentSequence = 1;
            }
            if (currentSequence >= bestSequence)
            {
                bestSequence = currentSequence;
                bestSequenceNumber = array[i];
            }
        }

        Console.Write("The maximal sequence of equal elements is: ");
        for (int i = 0; i < bestSequence; i++)
		{
            Console.Write(bestSequenceNumber + ",");
		}
        Console.WriteLine();
    }
}
