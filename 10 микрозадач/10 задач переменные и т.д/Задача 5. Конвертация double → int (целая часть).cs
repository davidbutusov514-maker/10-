using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int result = (int)x;

        Console.WriteLine(result);
    }
}