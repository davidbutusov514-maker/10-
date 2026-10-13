using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long fact = 1;

        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine(fact);
    }
}