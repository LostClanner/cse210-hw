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



    }

    public void EndActivity()
    {

    }


    public void Run()
    {

    }


    protected void ShowSpinner(int seconds)
    {

    }


    protected void ShowCountdown(int seconds)
    {

    }


    protected void PauseWithAnimation(int seconds, string message)
    {
        
    }
}