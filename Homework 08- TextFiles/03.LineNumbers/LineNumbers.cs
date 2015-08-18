//Problem 3. Line numbers
//
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\text.txt");
        var writer = new StreamWriter(@"..\..\output.txt");
        int count = 1;
        string currentLine = reader.ReadLine();

        using (reader)
        {
            using (writer)
            {
                while (currentLine != null)
                {
                    writer.WriteLine("{0}. {1}", count, currentLine);
                    count++;
                    currentLine = reader.ReadLine();
                }
            }
        }
    }
}