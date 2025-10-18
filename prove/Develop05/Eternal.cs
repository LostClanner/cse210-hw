using System;



public class Eternal : Goal
{
    public Eternal(string name, string summary) : base(name, summary, 0)
    {
    }
    
    public override int RecordEvent()
    {
        return _points;
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDisplayString()
    {
        string display = $"[@] {_name}, {_summary}.";
    }

}