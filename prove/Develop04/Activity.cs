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
        Console.WriteLine($"Welcome to the {_activityName}!");
        ShowSpinner(3);
        Console.WriteLine("Your going to love it!");
        ShowCountdown(5);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Thanks for completing the {_activityName}!");
        ShowSpinner(3);
        Console.WriteLine("You have acomplished something great!");
        ShowSpinner(3);
    }


    public void Run()
    {

    }


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


    protected void ShowCountdown(int seconds)
    {
        int i = seconds;
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i--;

    }


    // protected void PauseWithAnimation(int seconds, string message)
    // {
        
    // }
}