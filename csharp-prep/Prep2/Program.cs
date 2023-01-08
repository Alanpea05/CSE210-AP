using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your grade (Percentage)? ");
        string grade = Console.ReadLine(); 
        int grade_n = int.Parse(grade);

        string letter = "";
        
        if (grade_n >= 90) {
            letter = ("A!");
        }
        else if (grade_n >= 80){
            letter = ("B!");
        }
        else if (grade_n >= 70){
            letter = ("C!");
        }
        else if (grade_n >= 60){
            letter = ("D!");
        }
        else{
            letter = ("F");
        }
        Console.WriteLine("");
        Console.WriteLine($"Your grade is {letter}");

        if (grade_n >= 70){
            Console.WriteLine("Congratulation! You passed the course");
        }
        else {
            Console.WriteLine("Sorry, you can do better, try a little harder next time! ");
        }
        Console.WriteLine("");

    }
}