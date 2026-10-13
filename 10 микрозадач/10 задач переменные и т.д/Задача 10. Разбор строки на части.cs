using System;

class Program
{
    static void Main()
    {
        string[] p = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int a = int.Parse(p[0]);
        int b = int.Parse(p[1]);

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
    }
}