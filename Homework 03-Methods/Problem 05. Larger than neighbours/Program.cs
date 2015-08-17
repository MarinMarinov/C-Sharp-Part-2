/*Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours
(when such exist).*/

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
        Console.Write("Enter the element index: ");
        int index = int.Parse(Console.ReadLine());

        if (FindElementLargerThanNeighbours(array, index))
        {
            Console.WriteLine("Element on position {0} is bigger than its two neighbours", index);
        }
        else
        {
            Console.WriteLine("Element on position {0} is not bigger than its two neighbours", index);
        }
    }

    static bool FindElementLargerThanNeighbours(int[] array, int index)
    {
        bool check = false;
        if ((index > 0) && (index < array.Length -1))
        {
            if ((array[index] > array[index+1]) && (array[index] > array[index-1]))
            {
                check = true;
            }
        }
        else if (index == 0)
        {
            if ((array[index] > array[index + 1]) && (array[index] > array[array.Length]))
            {
                check = true;
            }
        }
        else if (index == array.Length-1)
        {
            if ((array[index]>array[index-1]) && (array[index]>array[0]))
            {
                check = true;
            }
        }

        return check;
    }
}