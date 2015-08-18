/*Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days    */

using System;
using System.Globalization;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter start date in format dd.mm.yyyy: ");
        string start = Console.ReadLine();

        Console.WriteLine("Enter end date in format dd.mm.yyyy: ");
        string end = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine((endDate - startDate).TotalDays);
    }
}