/*Problem 10. Find sum in arrayay

Write a program that finds in given array of integers a sequence of given sum S (if present).
 Example:

arrayay	                     S	                result
4, 3, 1, 4, 2, 5, 8	        11	                4, 2, 5
 
 
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insert size of the Array: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        Console.Write("Enter sum: ");

        int sum = int.Parse(Console.ReadLine());

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Insert array element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int currentSum = 0;
        int startIndex = 0;

        for (int i = 0; i < arrayLength - 1; i++)
        {
            currentSum += array[i];
            startIndex = i;
            for (int j = i + 1; j < arrayLength; j++)
            {
                currentSum += array[j];
                if (currentSum == sum)
                {
                    for (int k = startIndex; k <= j; k++)
                    {
                        Console.WriteLine("{0} ", array[k]);
                    }
                    break;
                }
            }
            currentSum = 0;
        }
    }
}
