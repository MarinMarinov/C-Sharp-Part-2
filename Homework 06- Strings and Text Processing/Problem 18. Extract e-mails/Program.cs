/*Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
        string email = "ala bala nababahvarchiloto@xyz.net u doma baba@domain.bg";
        //string regex = @"\w+@\w+\.\w+";

        //MatchCollection matches = Regex.Matches(email, regex, RegexOptions.IgnorePatternWhitespace);

        //foreach (Match match in matches)
        //{
        //    Console.WriteLine(match.Value);
        //}

        string[] splitedText = email.Split(' ', ',');
        //bool isEmail = false;
        List<string> listOfEmails = new List<string>();

        foreach(string word in splitedText)
        {
            for( int i=0; i< word.Length; i++)
            {
                if (word[i] == '@')
                {
                    listOfEmails.Add(word);
                }
            }
        }

        foreach (string mail in listOfEmails)
        {
            Console.WriteLine(mail);
        }
    }
}