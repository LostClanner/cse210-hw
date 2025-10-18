using System;



public class Simple : Goal
{
    private bool _isComplete = false;

    public Simple(string name, string summary, int points) : base(name, summary, points)
    {
    }
    
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDisplayString()
    {
        string completed = "[]";
        if (_isComplete)
        {
            completed = "[x]";
        }
        string display = $"{completed} {_name} {_summary}. And it's worth {_points} points!";
        return display;
    }

}