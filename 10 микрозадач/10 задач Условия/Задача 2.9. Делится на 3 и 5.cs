using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool result = n % 3 == 0 && n % 5 == 0;

        Console.WriteLine(result ? "true" : "false");
    }
}