using System;
using System.Text.Json.Serialization;



public class Simple : Goal
{
    public bool IsCompleteCheck { get; private set; } = false;

    [JsonConstructor]
    public Simple(string name, string summary, int points, bool isCompleteCheck) : base(name, summary, points)
    {
        this.IsCompleteCheck = isCompleteCheck;
    }

    public Simple(string name, string summary, int points) : base(name, summary, points)
    {
        
    }
    
    public override int RecordEvent()
    {
        if (IsCompleteCheck)
        {
            Console.WriteLine("The goal is already completed");
            return 0;
        }
        else
        {
        IsCompleteCheck = true;
        return Points;
        }

        
    }

    public override bool IsComplete()
    {
        return IsCompleteCheck;
    }

    public override string GetDisplayString()
    {
        string completed = "[]";
        if (IsCompleteCheck)
        {
            completed = "[x]";
        }
        string display = $"{completed} {Name}, {Summary}. And it's worth {Points} points!";
        return display;
    }

}