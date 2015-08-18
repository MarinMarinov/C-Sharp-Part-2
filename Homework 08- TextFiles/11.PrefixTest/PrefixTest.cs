﻿//Problem 11. Prefix "test"
//
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main(string[] args)
    {
        using (StreamWriter sw = new StreamWriter(@"..\..\output.txt"))
        {
            using (StreamReader sr = new StreamReader(@"..\..\test.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*\b", string.Empty);
                    sw.WriteLine(line);
                }
            }
        }
    }
}