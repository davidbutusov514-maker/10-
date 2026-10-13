using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 15 == 0)
            Console.WriteLine("FizzBuzz");
        else if (n % 3 == 0)
            Console.WriteLine("Fizz");
        else if (n % 5 == 0)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine(n);
    }
}