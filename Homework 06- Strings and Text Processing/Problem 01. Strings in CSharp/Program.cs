/*Problem 1. Strings in C

-Describe the strings in C#.
-What is typical for the string data type?
-Describe the most important methods of the String class.
*/

﻿using System;
using System.Text;


class StringsInCSharp
{
    static void Main()
    {
        Console.WriteLine("1. Describe the strings in C#:");
        Console.WriteLine();
        DescribeTheStrings();

        Console.WriteLine("2. What is typical for the string data type?");
        Console.WriteLine();
        DescribeTypicalForStrings();

        Console.WriteLine("3. Describe the most important methods of the String class:");
        Console.WriteLine();
        DescribeTheMostImportantMethodsOfTheStrings();
    }

    private static void DescribeTheStrings()
    {
        StringBuilder text = new StringBuilder();

        text.AppendLine("Strings are immutable sequences of characters (instances of the System.String Class in .NET Framework)");
        text.AppendLine(" a) They are declared by the keyword STRING");
        text.AppendLine(" b) Can be initialized by string literals");
        text.AppendLine(" c) They use Unicode to support multiple languages and alphabets, characters and symbols");
        text.AppendLine(" d) Stored in the dynamic memory (managed heap)");

        Console.WriteLine(text);
    }

    private static void DescribeTypicalForStrings()
    {
        StringBuilder text = new StringBuilder();

        text.AppendLine("System.String is reference type");
        text.AppendLine("String objects are like arrays of characters (char[])");
        text.AppendLine(" a) Strings have fixed length (String.Length)");
        text.AppendLine(" b) Elements can be accessed directly by index (the index is in the range [0..Length-1])");

        Console.WriteLine(text);
    }

    private static void DescribeTheMostImportantMethodsOfTheStrings()
    {
        StringBuilder text = new StringBuilder();

        text.AppendLine("Most important string methods are:");
        text.AppendLine(" a)Length \n b)this[]\n c)Compare(str1, str2)\n d)IndexOf(str)\n e)LastIndexOf(str)\n f)Substring(startIndex, length)\n g)Replace(oldStr, newStr)\n h)Remove(startIndex, length)\n i)ToLower()\n g)ToUpper()\n k)Trim() etc.");

        Console.WriteLine(text);
    }
}