/*Problem 14. Quick sort

Write a program that sorts an array of strings using the Quick sort algorithm.*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int arraylength = int.Parse(Console.ReadLine());

        string[] words = new string[arraylength];
        Console.WriteLine("Enter a {0} strings to array: ", arraylength);
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Before sorting: {0}", string.Join(", ", words));

        QuickSort(words, 0, words.Length - 1);

        Console.WriteLine("After sorting: {0}", string.Join(", ", words));
    }

    static void QuickSort(string[] elements, int left, int right)
    {
        if (left >= right) return; // Array with 1 element

        int leftPointer = left, rightPointer = right;

        string pivot = elements[(left + right) / 2];

        while (leftPointer <= rightPointer)
        {
            while (String.Compare(elements[leftPointer], pivot, StringComparison.Ordinal) < 0) leftPointer++;

            while (String.Compare(elements[rightPointer], pivot, StringComparison.Ordinal) > 0) rightPointer--;

            if (leftPointer <= rightPointer)
            {
                string swap = elements[leftPointer];
                elements[leftPointer] = elements[rightPointer];
                elements[rightPointer] = swap;

                leftPointer++; rightPointer--;
            }
        }
        if (left < rightPointer)
        {
            QuickSort(elements, left, rightPointer);
        }
        if (leftPointer < right)
        {
            QuickSort(elements, leftPointer, right);
        }
    }
}