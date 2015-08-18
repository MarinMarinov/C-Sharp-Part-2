﻿/*Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.    */

using System;
using System.Threading;
using System.Globalization;


class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        try
        {
            //input is int so it can be converted without exception to all formats below
            Console.Write("Insert an integer number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0, 15:F2}", number);    // decimal
            Console.WriteLine("{0, 15:X}", number);     // hexadecimal
            Console.WriteLine("{0, 15:P}", number);     // percentage
            Console.WriteLine("{0, 15:E}", number);     // scientific notation
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}