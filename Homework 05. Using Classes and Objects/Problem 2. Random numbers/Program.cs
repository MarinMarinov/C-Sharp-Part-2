/*
 * Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;

class Program
{
    static void Main()
    {
        Random generator = new Random();
        for (int i = 0; i < 10; i++)
        {
            int randomNumber = generator.Next(100, 201); // gives number in interval [100,200]
            Console.WriteLine(randomNumber);
            //Console.WriteLine(generator.Next(100, 200)); // gives number in interval [100,199]
        }
    }
}