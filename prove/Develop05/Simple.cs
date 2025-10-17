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

    public override void GetDisplayString()
    {
        Console.WriteLine("--- Goal ---");
        Console.WriteLine(_name);
        Console.WriteLine(_summary);
        Console.WriteLine($"It is worth {_points} points.");
        Console.WriteLine("--- End ---");
        Console.WriteLine("");

    }

}