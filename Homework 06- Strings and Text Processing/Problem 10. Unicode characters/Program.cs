/*Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	        output
Hi!	        \u0048\u0069\u0021    */

using System;
using System.Text;


class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        byte[] uniByte = Encoding.Unicode.GetBytes(str);
        string uniString = string.Empty;

        foreach (byte b in uniByte)
        {
            if (b == 0)
            {
                continue;
            }

            uniString += string.Format("{0}{1}", "\\u", b.ToString("X").PadLeft(4, '0'));
        }

        Console.WriteLine(uniString);
    }
}