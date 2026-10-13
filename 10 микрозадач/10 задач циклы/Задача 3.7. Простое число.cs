using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = n > 1;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? "true" : "false");
    }
}