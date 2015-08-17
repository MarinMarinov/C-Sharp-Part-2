/*Problem 6. Binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();      
        Console.WriteLine("The hexadecimal number of this binary number is: " + DecimalToHexadecimal(BinaryToDecimal(binaryNumber)));
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

    static string DecimalToHexadecimal(long decimalNumber)
    {
        string hexadecimal = "";

        while (decimalNumber > 0)
        {
            var remainder = decimalNumber % 16;
            if (remainder >= 0 && remainder <= 9)
            {
                hexadecimal = (char)(remainder + '0') + hexadecimal;
            }
            else if (remainder >= 10 && remainder <= 15)
            {
                hexadecimal = (char)(remainder - 10 + 'A') + hexadecimal;
            }

            decimalNumber /= 16;
        }

        return hexadecimal;
    }
}