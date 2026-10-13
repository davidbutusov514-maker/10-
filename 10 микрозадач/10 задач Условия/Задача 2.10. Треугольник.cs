using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool ok = a + b > c && a + c > b && b + c > a;

        Console.WriteLine(ok ? "true" : "false");
    }
}