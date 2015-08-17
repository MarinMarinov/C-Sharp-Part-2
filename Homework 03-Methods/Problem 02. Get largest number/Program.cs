/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().*/

using System;


class Program
{
    static void Main()
    {
        int firstNumber = GetNumber("first number");
        int secondNumber = GetNumber("second number");
        int thirdNumber = GetNumber("third number");

        Console.WriteLine("The biggest number is {0}", GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
    }
    static int GetNumber(string numbers)
    {
        int number = int.MinValue;
        bool isNumber = false;

        do
        {
            Console.Write("Enter {0}, better to be really a number: ", numbers);
            isNumber = int.TryParse(Console.ReadLine(), out number);

        } 
        while (isNumber == false);

        return number;
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else if (firstNumber < secondNumber)
        {
            return secondNumber;
        }
        else
        {
            return firstNumber;
        }
    }
}