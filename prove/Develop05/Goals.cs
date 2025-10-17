using System;


public abstract class Goal
{

    protected string _name;
    protected string _summary;
    protected int _points;


    public Goal(string name, string summary, int points)
    {
        _name = name;
        _summary = summary;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract void GetDisplayString();

}