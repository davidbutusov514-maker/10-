using System;

class Program
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if (score >= 90)
            Console.WriteLine(5);
        else if (score >= 75)
            Console.WriteLine(4);
        else if (score >= 60)
            Console.WriteLine(3);
        else
            Console.WriteLine(2);
    }
}