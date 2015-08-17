/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Insert number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Insert number K: ");
        int k = int.Parse(Console.ReadLine());

        int sum = 0;
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Insert array element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);   
     
        for (int i = 0; i < k; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("The sum of the biggest K numbers in the Array is: " + sum);
    }
}