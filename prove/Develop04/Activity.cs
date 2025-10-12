using System;



public abstract class Activity
{

    protected string _activityName;
    protected string _description;
    protected int _duration;


    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    //The start that they all have
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();


        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());


        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
    }

    //The end that they all have
    public void EndActivity()
    {
        Console.WriteLine($"Thanks for completing the {_activityName}!");
        Console.WriteLine($"You spent {_duration} seconds on it");
        ShowSpinner(4);
        Console.Clear();
    }

    // all the programs run a little different, so Abstraction for the win!
    public abstract void Run();


    //this just spins for however long that you say

    protected void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>()
        {
            "|", "/", "-", "\\"
        };

        // DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    //This is just a countdown for however long you put in
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}