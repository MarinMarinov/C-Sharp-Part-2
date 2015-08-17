/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).*/


using System;

class Program
{
    static void Main() // The code is the same as Problem 2, with only changed "int" to "char" type variables
    {
        Console.WriteLine("Insert size of the first array");
        int firstArraySize = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert size of the second array");
        int secondArraySize = int.Parse(Console.ReadLine());

        char[] firstArray = new char[firstArraySize];
        char[] secondArray = new char[secondArraySize];
        bool isEqual = true;

        if (firstArraySize == secondArraySize)
        {
            Console.WriteLine("Insert the elements of the first array:");
            for (int i = 0; i < firstArraySize; i++)
            {
                Console.Write("Insert first array [{0}] =", i);
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insert the elements of the second array:");
            for (int i = 0; i < firstArraySize; i++)
            {
                Console.Write("Insert second array [{0}] =", i);
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArraySize; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    break;
                }
                else
                {
                    isEqual = true;
                }
            }
            Console.WriteLine("The arrays are Equal = " + isEqual);
        }
        else
        {
            isEqual = false;
            Console.WriteLine("Equal = " + isEqual);
        }
    }
}
