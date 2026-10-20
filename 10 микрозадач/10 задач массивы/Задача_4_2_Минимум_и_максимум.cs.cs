using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        int min = a[0], max = a[0];
        foreach (int x in a)
        {
            if (x < min) min = x;
            if (x > max) max = x;
        }
        Console.WriteLine("min=" + min + " max=" + max);
    }
}