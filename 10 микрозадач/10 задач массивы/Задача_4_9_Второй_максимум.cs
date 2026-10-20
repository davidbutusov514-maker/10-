using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(parts, int.Parse);
        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int x in a)
        {
            if (x > max1) { max2 = max1; max1 = x; }
            else if (x > max2 && x <= max1) max2 = x;
        }
        Console.WriteLine(max2);
    }
}