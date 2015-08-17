/*
 Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("The number in hexadecimal is: " + DecimalToHexadecimal(decimalNumber));
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
                hexadecimal = (char)(remainder - 10 + 'A')+ hexadecimal;                
            }
            
            decimalNumber /= 16;
        }
       
        return hexadecimal;
    }
}