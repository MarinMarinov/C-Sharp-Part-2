/*Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time
after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.    */

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please insert date and time in format dd.mm.yyyy hour:minute:second");
        string dateAndTime = Console.ReadLine();

        DateTime date = DateTime.ParseExact(dateAndTime, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        Console.WriteLine(date);

        DateTime newDateAndTime = date.AddHours(6).AddMinutes(30);

        Console.Write(newDateAndTime);
        Console.WriteLine(newDateAndTime.DayOfWeek);

        var bgCulture = new System.Globalization.CultureInfo("bg-Bg");
        string dayInBulgarian = bgCulture.DateTimeFormat.GetDayName(newDateAndTime.DayOfWeek);

        Console.WriteLine(dayInBulgarian);
    }
}