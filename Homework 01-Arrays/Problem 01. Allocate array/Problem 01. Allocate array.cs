/*Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.*/


using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }

        //printing array elements each on a new row
        for (int i = 0; i < numbers.Length; i++) 
        {
            Console.WriteLine(numbers[i]);
        }

        // prinitng in row, separated by comma and space, using for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
        Console.WriteLine();

        //printing in row, separated by comma and space, using string.Join method

        string numbersAsString = string.Join(", ", numbers).ToString();
        Console.WriteLine(numbersAsString);
    }
}