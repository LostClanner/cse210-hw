using System;


public class BreathingActivity : Activity
{
    private int _repetitions = 0;
    private int _breathInterval = 0;

    public BreathingActivity(string activityName, string description, int duration, int repetitions, int breathInverval)
    {
        _repetitions = repetitions;
        _breathInterval = breathInverval;

    }

    public void run()
    {
        
    }

}