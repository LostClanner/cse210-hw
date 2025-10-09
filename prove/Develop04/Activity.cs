using System;



public class Activity
{

    protected string _activityName = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to your welness {_activityName}!");


    }

    public void EndActivity()
    {
        Console.WriteLine($"Thanks for completing the {_activityName}!");
    }


    public void Run()
    {

    }


    protected void ShowSpinner()
    {
        List<string> animationString = new List<string>()
        {
            "|", "/", "-", "\\"
        };

        // DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

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


    protected void ShowCountdown(int seconds)
    {
        int i = seconds;
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");

    }


    // protected void PauseWithAnimation(int seconds, string message)
    // {
        
    // }
}