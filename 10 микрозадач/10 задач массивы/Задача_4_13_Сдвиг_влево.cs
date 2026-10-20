using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        
        int first = a[0];
        for (int i = 0; i < a.Length - 1; i++) a[i] = a[i + 1];
        a[a.Length - 1] = first;
        
        Console.WriteLine(string.Join(" ", a));
    }
}