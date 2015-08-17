/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Insert the size of the array = ");
        int arraySize = int.Parse(Console.ReadLine());

        int bestSequence = 1;
        int currentSequence = 1;
        string smallestSequenceNumber = "";
        string biggestSequenceNumber = "";
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Insert the array element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currentSequence++;
                smallestSequenceNumber += array[i] + " ";
            }
            else
            {
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    smallestSequenceNumber += array[i] + " ";
                    biggestSequenceNumber = smallestSequenceNumber;
                }
                else
                {
                    currentSequence = 1;
                    smallestSequenceNumber = ""; 
                }                                 
            }            
        }
        if (currentSequence > bestSequence)
        {
            smallestSequenceNumber += array[array.Length - 1];
            biggestSequenceNumber = smallestSequenceNumber;
        }
        Console.WriteLine(biggestSequenceNumber);       
    }
}
