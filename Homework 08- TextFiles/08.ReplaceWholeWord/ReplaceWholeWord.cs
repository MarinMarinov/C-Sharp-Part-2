﻿//Modify the solution of the previous problem to replace only whole words (not substrings).

using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
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
                    line = Regex.Replace(line, @"\bala\b", "portokala");
                    sw.WriteLine(line);
                }
            }
        }
    }
}