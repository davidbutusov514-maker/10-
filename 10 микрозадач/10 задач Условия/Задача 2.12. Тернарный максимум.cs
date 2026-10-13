using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int m = a > b ? (a > c ? a : c) : (b > c ? b : c);

        Console.WriteLine(m);
    }
}