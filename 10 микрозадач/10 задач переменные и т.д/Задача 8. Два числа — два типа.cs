using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double sum = a + b;
        int prod = (int)(a * b);

        Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(prod);
    }
}