using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int a = 1;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int temp = a + b;
            a = b;
            b = temp;
        }
    }
}