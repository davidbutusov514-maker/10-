using System;

class Program
{
    static void Main()
    {
        char c = Console.ReadLine()[0];

        if (char.IsLetter(c))
            Console.WriteLine("буква");
        else if (char.IsDigit(c))
            Console.WriteLine("цифра");
        else
            Console.WriteLine("другое");
    }
}