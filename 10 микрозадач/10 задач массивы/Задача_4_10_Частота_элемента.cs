using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        int x = int.Parse(Console.ReadLine());
        int count = 0;
        foreach (int item in a) if (item == x) count++;
        Console.WriteLine(count);
    }
}