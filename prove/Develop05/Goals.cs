using System;


abstract class Goal
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

    abstract int RecordEvent();

    abstract bool IsComplete();

    abstract string GetDisplayString();

}