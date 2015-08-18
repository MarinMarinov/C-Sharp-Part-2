/*
 Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose method for calculating surface of a triangle:");
        Console.WriteLine("1. Side and an altitude to it (press 1);");
        Console.WriteLine("2. Three sides (press 2);");
        Console.WriteLine("3. Two sides and an angle between them (press 3);");

        int method = int.Parse(Console.ReadLine());

        switch (method)
        {
            case 1: FindSurfaceBySideAndAltitude(); break;
            case 2: FindSurfaceByThreeSides(); break;
            case 3: FindSurfaceByTwoSidesAndAngle(); break;
            default: Console.WriteLine("There is no such method"); break;
        }

    }

    private static void FindSurfaceBySideAndAltitude()
    {
        Console.Write("Insert side lenght: ");
        double side = double.Parse(Console.ReadLine());

        Console.Write("Insert altitude lenght: ");
        double altitude = double.Parse(Console.ReadLine());

        double surface = side * altitude / 2;

        Console.WriteLine("The triangle surface is: {0:0.000}", surface);
    }

    private static void FindSurfaceByThreeSides()
    {
        /*Area of a triangle = √(s(s-a)(s-b)(s-c)) by Heron's Formula,
        where a, b and c are the lengths of the sides of the triangle, and s = ½ (a + b + c)
        is the semi-perimeter of the triangle.*/

        Console.Write("Insert side A lenght: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Insert side B lenght: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Insert side C lenght: ");
        double sideC = double.Parse(Console.ReadLine());

        double perimeter = sideA + sideB + sideC;
        double surface = Math.Sqrt(perimeter / 2 * (perimeter/2 - sideA) * (perimeter/2 - sideB) * (perimeter/2 - sideC));

        Console.WriteLine("The triangle surface is: {0:0.000}", surface);
    }

    private static void FindSurfaceByTwoSidesAndAngle()
    {
        /*If two sides and the angle between them are given, the area of the triangle can be determined using the following formula: 
        Area = ½ · a · b · sinC = ½ · b · c · sinA = ½ · a · c · sin B */
        Console.Write("Insert side A lenght: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Insert side B lenght: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Insert angle(in degrees) between these two sides: ");
        double angleInDegrees = double.Parse(Console.ReadLine());

        double angleInRadians = angleInDegrees * Math.PI / 180;
        double sinusAngleInRadians = Math.Sin(angleInRadians);
        double surface = sideA * sideB * sinusAngleInRadians / 2;

        Console.WriteLine("The triangle surface is: {0:0.000} ", surface);
    }
}