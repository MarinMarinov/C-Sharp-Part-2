//Problem 7. Replace sub-string
//
//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter(@"..\..\output.txt"))
        {
            using (StreamReader sr = new StreamReader(@"..\..\test.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = line.Replace("ala bala", "portokala");
                    sw.WriteLine(line);
                }
            }
        }
    }
}