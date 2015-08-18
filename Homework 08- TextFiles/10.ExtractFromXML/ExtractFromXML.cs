//Problem 10. Extract text from XML
//
//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;

class GetXMLWords
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader(@"..\..\test.xml"))
        {
            string line;
            string words = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '<')
                    {
                        while (line[i] != '>')
                        {
                            i++;
                            continue;
                        }
                    }
                    else
                    {
                        words += line[i];
                        if (line[i + 1] == '<')
                        {
                            Console.WriteLine(words);
                            words = "";
                        }
                    }
                }
            }
        }
    }
}