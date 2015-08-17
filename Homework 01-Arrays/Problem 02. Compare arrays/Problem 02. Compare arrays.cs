/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insert size of the first array");
        int firstArraySize = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert size of the second array");
        int secondArraySize = int.Parse(Console.ReadLine());

        int[] firstArray = new int[firstArraySize];
        int[] secondArray = new int[secondArraySize];        

        if (firstArraySize == secondArraySize)
        {
            Console.WriteLine("Insert the elements of the first array:");
            for (int i = 0; i < firstArraySize; i++)
            {
                Console.Write("Insert first array [{0}] =", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insert the elements of the second array:");
            for (int i = 0; i < firstArraySize; i++)
            {
                Console.Write("Insert second array [{0}] =", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool isEqual = false;

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
            Console.WriteLine("The arrays are with different lenght");
        }
    }
}