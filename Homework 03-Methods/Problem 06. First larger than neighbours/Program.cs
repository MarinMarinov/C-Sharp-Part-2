/*
Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter array element [{0}]= ", i);
            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);

            if (isNumber)
            {
                array[i] = number;
            }
            else
            {
                Console.WriteLine("This is not a number, so the element value is set to 0");
            }
        }

        Console.Write("The array is: ");

        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();

        int index = FindFirstLargerThanNeighbours(array);
        Console.WriteLine("First element larger than neighbours is at index {0}", index);
    }

    static int FindFirstLargerThanNeighbours(int[] array)
    {
        int index = -1;

        for (int i = 0; i < array.Length-1; i++)
        {            
            if (array[i] > array[i+1] && array[i] > array[i-1])
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }

        return index;
    }
}