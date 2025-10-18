using System;



public class Eternal : Goal
{
    public Eternal(string name, string summary, int points) : base(name, summary, points)
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


}