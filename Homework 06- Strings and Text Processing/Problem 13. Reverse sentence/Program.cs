/*Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
Example:

input	                                                output
C# is not C++, not PHP and not Delphi!            Delphi not and PHP, not C++ not is C#!              */

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";

        string[] words = text.Split(new char[] { ' ', '!', '?', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        //creating List containing all chars needed to split by
        List<char> excludedChars = new List<char>();

        for (char i = 'a'; i <= 'z'; i++)
        {
            excludedChars.Add(i);
        }

        for (char i = 'A'; i <= 'Z'; i++)
        {
            excludedChars.Add(i);
        }

        for (char i = '0'; i <= '9'; i++)
        {
            excludedChars.Add(i);
        }

        excludedChars.Add('#');
        excludedChars.Add('+');

        //foreach (char sign in signs)
        //{
        //    Console.Write(sign);
        //}

        // this array holds the only the elements like comma, or dot etc, different from the excludedChars
        string[] splitElements = text.Split(excludedChars.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        var reversedText = new StringBuilder();

        for (int i = 0; i < splitElements.Length; i++)
        {
            reversedText.Append(words[i]);
            reversedText.Append(splitElements[i]);
        }

        Console.WriteLine(reversedText.ToString());
    }
}