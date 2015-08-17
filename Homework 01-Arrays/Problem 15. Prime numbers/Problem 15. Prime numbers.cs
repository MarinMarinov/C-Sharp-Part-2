/*Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.*/


using System;

class Program
{
    static void Main(string[] args)
    {
        bool[] booleans = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(booleans.Length); i++)
        {
            if (booleans[i] == false)
            {
                for (int j = i * i; j < booleans.Length; j = j + i)
                {
                    booleans[j] = true;
                }
            }
        }
        for (int i = 2; i < booleans.Length; i++)
        {
            if (booleans[i] == false)
            {
                Console.WriteLine("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}