using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List <int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished"); 
        while (number != 0){        
            Console.WriteLine("Enter a number:");
            string new_numb = Console.ReadLine();
            number = int.Parse(new_numb);         
            numbers.Add(number);
        }

        
        Console.WriteLine($"The Sum is: {numbers.Sum()}" );

        Console.WriteLine($"The Average is {numbers.Average()}");

        Console.WriteLine($"Largest number: {numbers.Max()}");
    }
}