/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented
as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as
a dynamic language in ***.    */

using System;


class Program
{
    static void Main()
    {

        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] words = text.Split('.', ' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == "PHP" || words[i] == "CLR" || words[i] == "Microsoft")
            {
                text = text.Replace(words[i], new string('*', words[i].Length));
            }
        }

        Console.WriteLine(text);
        
        // Another solution for any text and any forbidden words   
     
        /*Console.Write("Enter text to check for forbidden words: ");
        string text = Console.ReadLine();

        Console.WriteLine("Enter forbidden words:");
        string forbiddenWords = Console.ReadLine();
        

        string[] splitText = text.Split(',', '.', ' ', ';', '!', '?');
        string[] forbiddenSplitWords = forbiddenWords.Split(',', '.', ' ', ';', '!', '?');
        string censuredText = "";
        //string[] censuredText = new string[splitText.Length];
        for (int i = 0; i < splitText.Length; i++)
        {
            for (int j = 0; j < forbiddenSplitWords.Length; j++)
            {
                if (splitText[i] == forbiddenSplitWords[j])
                {
                    censuredText = text.Replace(splitText[i], new string('*', 3));
                }
            }
        }
        Console.WriteLine(censuredText);*/
    }
}