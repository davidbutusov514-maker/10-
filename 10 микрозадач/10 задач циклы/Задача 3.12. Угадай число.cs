using System;

class Program
{
    static void Main()
    {
        int secret = int.Parse(Console.ReadLine());
        int attempts = 0;

        while (true)
        {
            int guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess == secret)
            {
                Console.WriteLine("угадал за " + attempts + " попыток");
                break;
            }
            else if (guess > secret)
            {
                Console.WriteLine("больше");
            }
            else
            {
                Console.WriteLine("меньше");
            }
        }
    }
}