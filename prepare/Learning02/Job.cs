using System;
public class Job{
    public String _nameCompany;
    public String _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {(_nameCompany)} {_startYear}-{_endYear}");
    }
}