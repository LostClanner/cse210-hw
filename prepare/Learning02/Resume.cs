using System;



public class Resume
{

    public string _name;
    public List<JobHistory> _jobs = new List<JobHistory>();

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