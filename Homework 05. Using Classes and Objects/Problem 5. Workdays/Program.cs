/*
 Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

using System;
using System.Linq;

class Program
{
    static readonly DateTime[] holidays =
	{
		new DateTime(2015, 1, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
		new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
		new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
		new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
	};

    static readonly DateTime[] workingWeekends =
	{
		new DateTime(2015, 1, 2), new DateTime(2015, 3, 2), new DateTime(2015, 9, 21),
		new DateTime(2015, 12, 31)
	};
    
    static void Main()
    {
        DateTime now = DateTime.Now;
        
        Console.Write("Enter a future date from 2015 in the format dd.MM.yyyy: ");
        string input = Console.ReadLine();

        int[] splitInput = input.Split('.').Select(int.Parse).ToArray();

        DateTime futureDate = new DateTime(splitInput[2], splitInput[1], splitInput[0]);
        Console.WriteLine("Total work days: {0}: ", NumberOfWorkDays(now, futureDate));
    }

    static int NumberOfWorkDays(DateTime now, DateTime futureDate)
    {
        int workDays = 0;

        if (now > futureDate)
        {
            Console.WriteLine("You have to enter a FUTURE date. Please, try again!");
        }        
        else
        {
            while ( now <= futureDate)
            {
                if (!holidays.Contains(now) && !workingWeekends.Contains(now)
                    && now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday)
	            {
                    workDays++;
	            }
                now = now.AddDays(1);
            }
            
        }

        return workDays;
    }
}