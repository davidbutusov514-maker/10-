using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double d = n;

        Console.WriteLine(d.ToString("F2", CultureInfo.InvariantCulture));
    }
}