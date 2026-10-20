using System;

class Program
{
    static void Main()
    {
        string[] p1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(p1, int.Parse);
        string[] p2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] b = Array.ConvertAll(p2, int.Parse);
        
        int[] result = new int[a.Length + b.Length];
        for (int i = 0; i < a.Length; i++) result[i] = a[i];
        for (int i = 0; i < b.Length; i++) result[a.Length + i] = b[i];
        
        Console.WriteLine(string.Join(" ", result));
    }
}