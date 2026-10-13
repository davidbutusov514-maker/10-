using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        long result = 1;

        for (int i = 0; i < n; i++)
        {
            result *= a;
        }

        Console.WriteLine(result);
    }
}