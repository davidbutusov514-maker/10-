using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        int count = 0;
        foreach (int x in a) if (x % 2 == 0) count++;
        Console.WriteLine(count);
    }
}