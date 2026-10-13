using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("ноль");
        }
        else
        {
            string sign = n > 0 ? "положительное" : "отрицательное";
            string parity = n % 2 == 0 ? "чётное" : "нечётное";

            Console.WriteLine(parity + " " + sign);
        }
    }
}