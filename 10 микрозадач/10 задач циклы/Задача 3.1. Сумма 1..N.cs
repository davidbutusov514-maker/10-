using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = 0;

        for (int i = 1; i <= n; i++)
        {
            s += i;
        }

        Console.WriteLine(s);
    }
}