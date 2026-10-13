using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        char op = Console.ReadLine()[0];

        if (op == '+')
            Console.WriteLine(a + b);
        else if (op == '-')
            Console.WriteLine(a - b);
        else if (op == '*')
            Console.WriteLine(a * b);
        else if (op == '/')
        {
            if (b == 0)
                Console.WriteLine("error");
            else
                Console.WriteLine(a / b);
        }
    }
}