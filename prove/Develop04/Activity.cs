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
        Console.WriteLine("Welcome to your welness ");


    }

    public void EndActivity()
    {

    }


    public void Run()
    {

    }


    protected void ShowSpinner(int _duration)
    {
        List<string> animationString = new List<string>()
        {
            "|", "/", "-", "\\"
        };

        // DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);


        // animationString.Add("|");
        // animationString.Add("/");
        // animationString.Add("-");
        // animationString.Add("\\");

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

    }


    protected void PauseWithAnimation(int seconds, string message)
    {
        
    }
}