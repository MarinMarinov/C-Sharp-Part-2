/*Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements
(the number of characters composing them).*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array length n= ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("[{0}]= ", i);
            array[i] = Console.ReadLine();
        }

        Array.Sort(array, (x,y) => x.Length.CompareTo(y.Length));

        foreach (string item in array)
        {
            Console.WriteLine(item);
        }
    }
}