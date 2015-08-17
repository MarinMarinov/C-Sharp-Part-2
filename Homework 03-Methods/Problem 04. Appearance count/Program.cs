/*Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.*/

using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter arrays length: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Array[{0}] = ", i);

            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);

            if (isNumber)
            {
                numbers[i] = number;
            }
        }

        Console.Write("Number: ");
        int num = int.Parse(Console.ReadLine());
        int count = CountAppearances(numbers, num);
        Console.WriteLine("Number {1} appears: {0} times", count, num);
    }
   
    public static int CountAppearances(int[] array, int number)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(number))
            {
                counter++;
            }
        }

        return counter;
    }
}