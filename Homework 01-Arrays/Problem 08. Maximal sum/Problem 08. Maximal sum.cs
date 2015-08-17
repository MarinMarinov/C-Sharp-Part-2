/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
Example:
        input	                                        result
        2, 3, -6, -1, 2, -1, 6, 4, -8, 8	            2, -1, 6, 4
 */

using System;

class Program
{
    static void Main()
    {
        
        // Uncoment for manual insert of array members
        //Console.Write("Insert array dimension: ");
        //int n = int.Parse(Console.ReadLine());

        //int[] array = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Insert array element [{0}] = ", i);
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        // Negative number array 
        //int[] array = {-9, -8, -8, -7, -6, -5, -1, -7, -6};

        // Example array
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int currentSum = array[0];
        int maxSum = array[0];
        int startIndex = 0;
        int finalIndex = 0;
        int tempIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }
            currentSum += array[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                tempIndex = startIndex;
                finalIndex = i;
            }
        }

        Console.WriteLine("The sequence with the maximal sum is:");
        for (int i = startIndex; i <= finalIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum of this sequence is: " + maxSum);
    }
}