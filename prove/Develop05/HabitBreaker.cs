using System;
using System.Text.Json.Serialization;



public class HabitBreaker : Goal
{
    [JsonConstructor]
    public HabitBreaker(string name, string summary, int points) : base(name, summary, points)
    {
        if (points > 0)
        {
            points = points * -1;
        }
    }
    
    public override int RecordEvent()
    {
        return Points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDisplayString()
    {
        string display = $"[!!] {Name}, {Summary}.";
        return display;
    }

}