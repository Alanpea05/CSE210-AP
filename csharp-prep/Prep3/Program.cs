using System;


class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_n = randomGenerator.Next(1,101);
        int guess_n = -1;

        while (guess_n != magic_n){
            Console.WriteLine("What is your guess? ");
            string guess_num = Console.ReadLine(); 
            guess_n = int.Parse(guess_num);
            Console.WriteLine("");

            if (guess_n > magic_n){
                Console.WriteLine("lower");
            }
                else if (guess_n == magic_n){
                
                    Console.WriteLine("Congrats you guessed!");
                    }

            else {
                Console.WriteLine("Higher");
            }
        }

    }
}