using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        foreach (string s in parts) sum += int.Parse(s);
        Console.WriteLine(sum);
    }
}