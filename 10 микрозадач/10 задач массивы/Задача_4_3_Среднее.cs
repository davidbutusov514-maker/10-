using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        int sum = 0;
        foreach (int x in a) sum += x;
        double avg = (double)sum / a.Length;
        Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));
    }
}