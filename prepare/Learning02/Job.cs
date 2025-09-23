using System;


public class JobHistory
{

    //Gets the job info from the Program.cs
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Displays the job info
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}