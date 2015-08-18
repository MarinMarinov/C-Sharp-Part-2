//Problem 6. Save sorted names
//
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SaveSortedNames

{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\test.txt", Encoding.ASCII);
        StreamWriter writer = new StreamWriter(@"..\..\sorted.txt", true);

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                List<string> names = new List<string>();
                names.Add(new string('-', 40));

                do
                {
                    names.Add(line);
                    line = reader.ReadLine();
                    
                } while (line != null);

                Console.WriteLine("Strings from file:");

                foreach (string name in names)
                {
                    Console.Write(name + " ");
                }

                Console.WriteLine();

                names.Sort();
                Console.WriteLine("Names will now be sortred in sorted.txt:");

                foreach (string name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}