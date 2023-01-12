using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(UserNumber);
        DisplayResult(UserName, squaredNumber);
    }

        static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
        
    }

    static string PromptUserName(){
        Console.WriteLine("What's your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number){  
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name,  int square){
        Console.WriteLine($"Brother {name}, the square of your number is 1764");
    }
        
    }