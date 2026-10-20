using System;

class Program
{
    static void Main()
    {
        string[] p1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] a = Array.ConvertAll(p1, int.Parse);
        string[] p2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] b = Array.ConvertAll(p2, int.Parse);
        
        bool[] printed = new bool[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            if (printed[i]) continue;
            bool inB = false;
            foreach (int x in b) if (x == a[i]) { inB = true; break; }
            
            if (inB)
            {
                Console.Write(a[i] + " ");
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] == a[i]) printed[j] = true;
            }
        }
    }
}