using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        List<int> result = new List<int>();
        foreach (int x in a) if (x >= 0) result.Add(x);
        Console.WriteLine(string.Join(" ", result));
    }
}