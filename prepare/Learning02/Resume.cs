using System;



public class Resume
{

    //Gets the name
    public string _name;
    public List<JobHistory> _jobs = new List<JobHistory>();

    // Displays the name and job info

    public void Display()
    {
        Console.WriteLine($"name: {_name}");
        Console.WriteLine("Work expirence:");
        foreach (JobHistory job in _jobs)
        {
            job.Display();
        }
    }





}