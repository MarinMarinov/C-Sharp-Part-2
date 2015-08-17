/*Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexaDecimal = Console.ReadLine();
        Console.WriteLine("Binary number of that hexadecimal is: "+ DecimalToBinarySecondMethod(HexadecimalToDecimal(hexaDecimal)));

    }

    static long HexadecimalToDecimal(string hexaDecimal)
    {
        long decimalNumber = 0;

        for (int i = 0; i < hexaDecimal.Length; i++)
        {
            int digit = 0;
            if (hexaDecimal[i] > '0' && hexaDecimal[i] <= '9')
            {
                digit = hexaDecimal[i] - '0';
            }
            else if (hexaDecimal[i] >= 'A' && hexaDecimal[i] <= 'F') 
            {
                             
                digit = hexaDecimal[i] - 'A' + 10;       
            }
            else if (hexaDecimal[i] >= 'a' && hexaDecimal[i] <= 'f')
            {
                
                digit = hexaDecimal[i] - 'a' + 10;      
            }

            decimalNumber += digit * (long)Math.Pow(16, hexaDecimal.Length - i - 1);
        }

        return decimalNumber;
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