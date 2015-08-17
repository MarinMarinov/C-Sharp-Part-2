/* This is authors exercise and is not part from the homework*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter base number: ");
        string number = Console.ReadLine();
        Console.Write("Enter numeral system: ");
        int numeralSystem = int.Parse(Console.ReadLine());
        Console.WriteLine("The number in {0} numeral system is: {1}", numeralSystem, BaseToDecimal(number, numeralSystem));
    }
    static long BaseToDecimal(string number, int numeralSystem)
    {
        long decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] > '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else if (number[i] >= 'A' && number[i] <= 'Z') // works only with capital letters
            {
                digit = number[i] - 'A' + 10;      
            }
            else if (number[i] >= 'a' && number[i] <= 'z')
            {
                
                digit = number[i] - 'a' + 10;      
            }
            decimalNumber += digit * (long)Math.Pow(numeralSystem, number.Length - i - 1);
        }
        return decimalNumber;
    }
}