/* This is authors exercise and is not part from the homework*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter numeral system: ");
        int numeralSystem = int.Parse(Console.ReadLine());
        Console.WriteLine("The number in {0} numeral system is: {1}", numeralSystem, DecimalToBase(decimalNumber, numeralSystem));
    }
    static string DecimalToBase(long decimalNumber, int numeralSystem)
    {
        string result = "";
        while (decimalNumber > 0)
        {
            var remainder = decimalNumber % numeralSystem;
            if (remainder >= 0 && remainder <= 9)
            {
                result = (char)(remainder + '0') + result;
               
            }
            else
            {
                result = (char)(remainder - 10 + 'A') + result;
            }
            
            decimalNumber /= numeralSystem;
        }
        
        return result;
    }
}