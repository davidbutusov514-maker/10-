using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        bool inside = x >= a && x <= b;

        Console.WriteLine(inside ? "true" : "false");
    }
}