using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._nameCompany = "NASA";
        job1._startYear = 2019;
        job1._endYear = 2022;
    

        Job job2 = new Job();
            job2._jobTitle = "Manager";
            job2._nameCompany = "Apple";
            job2._startYear = 2022;
            job2._endYear = 2023;  

        Resume the_resume = new Resume();
        the_resume.person_name = "Alan Peña";

        the_resume._jobs.Add(job1);
        the_resume._jobs.Add(job2);

        the_resume.Display();

        }



    

}