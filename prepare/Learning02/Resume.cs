using System;

public class Resume{

    public string person_name;
    public List<Job> _jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {person_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs){
            job.Display();
        }
        {
            
        }
    }

}