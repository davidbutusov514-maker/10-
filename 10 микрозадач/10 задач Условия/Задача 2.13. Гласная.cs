using System;

class Program
{
    static void Main()
    {
        char c = Console.ReadLine()[0];
        string vowels = "aeiouAEIOU";

        bool isVowel = vowels.Contains(c);

        Console.WriteLine(isVowel ? "true" : "false");
    }
}