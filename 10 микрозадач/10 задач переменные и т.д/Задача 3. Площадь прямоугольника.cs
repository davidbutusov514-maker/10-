using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = length * width;

        Console.WriteLine(area.ToString("F2", CultureInfo.InvariantCulture));
    }
}