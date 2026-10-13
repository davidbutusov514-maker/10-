using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int count = 0;

        while (true)
        {
            int x = int.Parse(Console.ReadLine());

            if (x == 0)
            {
                break;
            }

            sum += x;
            count++;
        }

        if (count == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine((double)sum / count);
        }
    }
}