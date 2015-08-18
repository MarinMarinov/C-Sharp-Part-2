/*
 Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
 
Example:

input	                output
"43 68 9 23 318"        461
 */

using System;
using System.Linq;


class Program
{
    static void Main()
    {
        Console.Write("Enter a sequence of positive integer values written into a string, separated by spaces: ");
        string input = Console.ReadLine();
        //string input = "43 68 9 23 318";

        Console.WriteLine("The sum is: " + Sum(input));
    }

    static int Sum(string input)
    {
        int[] splittedInput = input.Split(' ').Select(int.Parse).ToArray();

        //int sum = splittedInput.Sum(); // too lazy way

        int sum = 0;

        for (int i = 0; i < splittedInput.Length; i++)
        {
            sum += splittedInput[i];
        }

        return sum;
    }
}