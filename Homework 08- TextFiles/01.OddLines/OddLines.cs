//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        using (StreamReader stream = new StreamReader(@"..\..\text.txt"))
        {
            string[] allLines = stream.ReadToEnd().Split('\n');

            StringBuilder result = new StringBuilder();

            for (int line = 1; line < allLines.Length; line += 2)
            {
                result.AppendLine(allLines[line]);
            }

            if (result.Length == 0)
            {
                result.AppendLine("No text found!");
            }

            Console.WriteLine(result);
        }
    }
}