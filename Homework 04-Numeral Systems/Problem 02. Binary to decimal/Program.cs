/*Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.*/

using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine(); 
        long decimalNumber = BinaryToDecimal(binaryNumber);

        Console.WriteLine("The decimal number of this binary number is: " + decimalNumber);
    }

    static long BinaryToDecimal(string binaryNumber)
    {
        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int digit = binaryNumber[i] - '0';
            int position = binaryNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(2, position);
        }

        return decimalNumber;
    }
}