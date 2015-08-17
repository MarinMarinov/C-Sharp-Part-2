/*Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, 
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter array dimension n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K=");
        int k = int.Parse(Console.ReadLine());
        int count = 0;
        int[] array = new int[n];
        Console.Write("Enter array elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= k)
            {
                count = i + 1; //the position of k element 
            } 
        }
        
        Array.BinarySearch(array, count);
        if (k <= array[0])
        {
            Console.WriteLine("K = {0} is smaller than minimal element in the array!", k);
        }
        else
        {
            Console.WriteLine("The number {0} is the biggest one, smaller or equal to K={1}", count, k);
        }
    }
}