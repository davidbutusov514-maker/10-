using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n > 0 ? "+" : n < 0 ? "-" : "0");
    }
}