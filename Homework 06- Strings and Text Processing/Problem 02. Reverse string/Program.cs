/*Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas*/

using System;
using System.Linq;


class Program
{
    public static void Main()
    {
        Console.WriteLine("Insert some text: ");
        string input = Console.ReadLine();

        // Using System.Linq
        //string output = new string(input.Reverse().ToArray()); 
        //Console.WriteLine(output);

        // Using own method ReverseString
        Console.WriteLine(ReverseString(input));
    }

    public static string ReverseString(string text)
    {
        char[] textAsCharArray = text.ToCharArray();
        Array.Reverse(textAsCharArray);
        string reversedText = new string(textAsCharArray.ToArray());

        return reversedText;
    }
}