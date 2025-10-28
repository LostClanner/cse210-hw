using System;
using System.Text.Json.Serialization;
[JsonDerivedType(typeof(Simple), "simple")]
[JsonDerivedType(typeof(Eternal), "eternal")]
[JsonDerivedType(typeof(Checklist), "checklist")]
[JsonDerivedType(typeof(HabitBreaker), "habitBreaker")]

public abstract class Goal
{

    public string Name { get; set; }
    public string Summary { get; set; }
    public int Points { get; set; }


    public Goal(string name, string summary, int points)
    {
        Name = name;
        Summary = summary;
        Points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDisplayString();

}