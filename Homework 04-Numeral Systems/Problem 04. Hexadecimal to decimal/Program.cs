/*Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexaDecimal = Console.ReadLine();
        Console.WriteLine("The number in decimal is: " + HexadecimalToDecimal(hexaDecimal));
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
                digit = hexaDecimal[i] - '7';              
                //digit = hexaDecimal[i] - 'A' + 10;       //result is the same as the raw above
            }
            else if (hexaDecimal[i] >= 'a' && hexaDecimal[i] <= 'f')
            {
                //digit = hexaDecimal[i] - 'W';      //result is the same as the raw below   
                digit = hexaDecimal[i] - 'a' + 10;       
            }
            decimalNumber += digit *(long)Math.Pow(16, hexaDecimal.Length - i - 1);
        }

        return decimalNumber;
    }
}