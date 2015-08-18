/*Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.*/

using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter an year AD: ");
        int year = int.Parse(Console.ReadLine());

        if (year <= 0)
        {
            Console.WriteLine("The System.DateTime struct works in range 1-9999 year AD. So, mate, try again!");            
        }
        else
        {
            if (year < 2015)
            {
                Console.WriteLine("Was {0} a leap year? {1}", year, DateTime.IsLeapYear(year));
            }
            else if (year > 2015)
            {
                Console.WriteLine("Will {0} be a leap year? {1}", year, DateTime.IsLeapYear(year));
            }
            else
            {
                Console.WriteLine("Is {0} a leap year? {1}", year, DateTime.IsLeapYear(year));
                //Console.WriteLine("No, 2015 isn't a leap year.");
            } 
        }               
    }
}