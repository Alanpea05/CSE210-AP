using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Wht is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine($"Your name is {name}, {name} {last_name}");
    }
}