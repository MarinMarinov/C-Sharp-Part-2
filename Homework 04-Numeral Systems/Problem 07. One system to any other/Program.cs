/*Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        Console.Write("Enter FROM numeral system: ");
        int fromNumeralSystem = int.Parse(Console.ReadLine());

        Console.Write("Enter TO numeral system: ");
        int toNumeralSystem = int.Parse(Console.ReadLine());

        Console.WriteLine(DecimalToBase(BaseToDecimal(number, fromNumeralSystem), toNumeralSystem));
    }

    static long BaseToDecimal(string number, int fromNumeralSystem)
    {
        long decimalNumber = 0;

        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] > '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else if (number[i] >= 'A' && number[i] <= 'Z') // работи само с главни букви
            {
                digit = number[i] - 'A' + 10;
            }
            else if (number[i] >= 'a' && number[i] <= 'z')
            {

                digit = number[i] - 'a' + 10;
            }
            decimalNumber += digit * (long)Math.Pow(fromNumeralSystem, number.Length - i - 1);
        }

        return decimalNumber;
    }

    static string DecimalToBase(long decimalNumber, int toNumeralSystem)
    {
        string result = "";

        while (decimalNumber > 0)
        {
            var remainder = decimalNumber % toNumeralSystem;
            if (remainder >= 0 && remainder <= 9)
            {
                result = (char)(remainder + '0') + result;

            }
            else
            {
                result = (char)(remainder - 10 + 'A') + result;
            }

            decimalNumber /= toNumeralSystem;
        }

        return result;
    }
}