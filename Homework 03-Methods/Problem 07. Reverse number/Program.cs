/*
Write a method that reverses the digits of given decimal number.
Example:

input	output
256	    652
123.45	54.321
*/

using System;

class Program
{
    static int GetNumber(string name)
    {
        int number = int.MinValue;
        bool isNumber = false;

        do
        {
            Console.WriteLine("Enter {0}: ", name);
            isNumber = int.TryParse(Console.ReadLine(), out number); 
        } 
        while (isNumber == false);

        return number;
    }

    static long Reverse(int number)
    {
        long result = 0;
        while (number != 0)
        {
            result = result * 10 + (long)number % 10;
            number /= 10;
        }

        return result;
    }
    
    static void Main()
    {
        int someNumber = GetNumber("some number");
        long reversedNumber = Reverse(someNumber);
        Console.WriteLine("The reversed number is {0}", reversedNumber);
    }
}