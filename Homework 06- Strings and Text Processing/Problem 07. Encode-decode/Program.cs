/*Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
the second – with the second, etc. When the last key character is reached, the next is the first.    */

using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text to encode:");
        string text = Console.ReadLine();

        Console.WriteLine("Enter the key:");
        string key = Console.ReadLine();

        char [] charArray = text.ToCharArray();
        char [] keyArray = key.ToCharArray();

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                char charFromArray = charArray[i];
                char keyFromArray = key[j];

                charFromArray ^= keyFromArray;
                charArray[i] = charFromArray;

                i++;                
            }

            i = i -1;
        }

        foreach (var item in charArray)
        {
            Console.Write(item);
        }
        Console.WriteLine();

        //string resultText = new string(charArray);
        //Console.Write(resultText);
        //Console.WriteLine();
    }
}