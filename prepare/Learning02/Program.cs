using System;

class Program
{
    static void Main(string[] args)
    {
        // This is the list of Jobs and positions held
        JobHistory job1 = new JobHistory();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        JobHistory job2 = new JobHistory();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;


        // This calls the resume and has the name and lists the jobs afterward
        Resume myResume = new Resume();
        // this is how you set the name
        myResume._name = "Dustin Newbold";

        //This gives resume the jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // This displays what has been made
        myResume.Display();
        
    }






}