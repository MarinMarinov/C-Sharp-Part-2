/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Insert array lenght: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Insert array element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int count = 1;
        int maxCount = 1;
        int countedNumbers = 0;

        Array.Sort(array);

        for (int i = 0; i < arrayLength-1; i++)
        {
            if (array[i] == array[i+1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                countedNumbers = array[i];
            }
        }
        if (maxCount > 1)
        {
            Console.WriteLine("Most frequent number is {0}, counted {1} times.", countedNumbers, maxCount);
        }
        else
        {
            Console.WriteLine("No frequent inserted number");
        }
    }
}