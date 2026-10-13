using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool hasSeven = false;

        while (n > 0)
        {
            if (n % 10 == 7)
            {
                hasSeven = true;
                break;
            }

            n /= 10;
        }

        Console.WriteLine(hasSeven ? "true" : "false");
    }
}