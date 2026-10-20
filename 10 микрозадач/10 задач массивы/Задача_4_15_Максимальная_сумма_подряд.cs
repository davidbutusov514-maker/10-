using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        
        int maxSoFar = a[0];
        int currentMax = a[0];
        
        for (int i = 1; i < a.Length; i++)
        {
            currentMax = Math.Max(a[i], currentMax + a[i]);
            maxSoFar = Math.Max(maxSoFar, currentMax);
        }
        Console.WriteLine(maxSoFar);
    }
}