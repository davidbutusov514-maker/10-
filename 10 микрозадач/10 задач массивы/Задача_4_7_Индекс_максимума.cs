using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        int maxIndex = 0;
        for (int i = 1; i < a.Length; i++)
            if (a[i] > a[maxIndex]) maxIndex = i;
        Console.WriteLine(maxIndex);
    }
}