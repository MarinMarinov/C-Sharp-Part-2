/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Insert array length:");
        int arrayLength = int.Parse(Console.ReadLine());

        Console.Write("Enter a number wich index we are going to look for:");
        int number = int.Parse(Console.ReadLine());

        int[] numbers = new int[arrayLength];
        Console.WriteLine("Insert {0} numbers to array:", arrayLength);
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        Console.WriteLine("Sorted array: {0}", string.Join(", ", numbers));

        int index = BinarySearch(numbers, number, 0, numbers.Length);
        
        
        if (index != -1)
        {
            Console.WriteLine("Number {0} found at index: {1}", number, index);
        }
        else
        {
            Console.WriteLine("Number {0} not found!", number);
        }
    }

    private static int BinarySearch(int[] numbers, int value, int start, int end)
    {
        if (end < start)
        {
            return -1;
        }
        else
        {
            int middleIndex = (start + end) / 2;
            if (numbers[middleIndex] > value)
            {
               return BinarySearch(numbers, value, start, middleIndex - 1);
                
            }
            else if (numbers[middleIndex] < value)
            {
                return BinarySearch(numbers, value, middleIndex + 1, end);
            }
            else
            {
                return middleIndex;
            }
        }
    }
}
