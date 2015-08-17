/*Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.

Examples:

input	output
512	    two
1024	four
12309	nine
 */

using System;


class Program
{
    
    static int GetNumber(string numbers)
    {
        int number = int.MinValue;
        bool isNumber = false;

        do
        {
            Console.Write("Enter {0}, better to be really a number: ", numbers);
            isNumber = int.TryParse(Console.ReadLine(), out number);

        } while (isNumber == false);

        return number;
    }

    static string ReturnLastDigitAsWord(int number)
    {
        string digit = "";
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 1: digit = "One";
                    break;
            case 2: digit = "Two";
                    break;
            case 3: digit = "Three";
                    break;
            case 4: digit = "Four";
                    break;
            case 5: digit = "Five";
                    break;
            case 6: digit = "Six";
                    break;
            case 7: digit = "Seven";
                    break;
            case 8: digit = "Eight";
                    break;
            case 9: digit = "Nine";
                    break;
            default: digit = "Zero";
                     break;
        }

        return digit;
    }

    static void Main()
    {
        int someNumber = GetNumber("some number");
        Console.WriteLine("The last digit from the number {0} is {1} ",someNumber, ReturnLastDigitAsWord(someNumber));
    }
}