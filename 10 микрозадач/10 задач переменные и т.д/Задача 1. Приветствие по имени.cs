using System;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Привет, " + name + "! Тебе " + age + " лет.");
    }
}