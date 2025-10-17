using System;



public class Simple : Goal
{
    private bool _isComplete = false;

    public Simple(string name, string summary, int points) : base(name, summary, points)
    {
    }
    
    public override int RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        _isComplete = true;

    }

    public override string GetDisplayString()
    {
        
    }

}