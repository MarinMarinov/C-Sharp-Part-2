/*Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        
        long decimalNumber = long.Parse(Console.ReadLine());

        if (decimalNumber < 0)
        {
            decimalNumber = decimalNumber ^ long.MinValue;
        }

        Console.WriteLine("First  method result: " + DecimalToBinaryFirstMethod(decimalNumber));
        Console.WriteLine("Second method result: " + DecimalToBinarySecondMethod(decimalNumber));
    }
    
    static string DecimalToBinaryFirstMethod(long decimalNumber)
    {
        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            var remainder = decimalNumber % 2;
            binaryNumber += remainder;
            decimalNumber /= 2;
        }

        var numberAsCharArray = binaryNumber.ToCharArray();
        Array.Reverse(numberAsCharArray);
        binaryNumber = new string(numberAsCharArray);

        return binaryNumber;
    }

    static string DecimalToBinarySecondMethod(long decimalNumber)
    {
        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            var remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }   
     
        return binaryNumber;
    }
}