using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        double prod = (double)a * b;
        double div = (double)a / b;

        Console.WriteLine(prod.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(div.ToString("F2", CultureInfo.InvariantCulture));
    }
}