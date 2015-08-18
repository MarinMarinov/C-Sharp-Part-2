/*Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).    */

using System;


class Program
{
    static void Main()
    {
        Console.Write("Insert expression with brackets: ");
        string expression = Console.ReadLine();
        Console.WriteLine("Is the expression correct ? {0}", CheckExpression(expression));
    }

    static bool CheckExpression(string expression)
    {
        const char leftBracket = '(';
        const char rightBracket = ')';
        int bracketCount = 0;

        if (expression.IndexOf('(') > expression.IndexOf(')'))
        {
            return false;
        }

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == leftBracket)
            {
                bracketCount++;
            }
            else if (expression[i] == rightBracket)
            {
                bracketCount--;
            }
        }
        if (bracketCount == 0)
        {
            return true;
        }

        return false;
    }
}