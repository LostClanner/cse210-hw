using System;
using System.Text.Json.Serialization;



public class Checklist : Goal
{
    public bool IsCompleteCheck { get; private set; } = false;
    public int BonusPoints { get; private set; }
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; } = 0;



    public Checklist(string name, string summary, int points, int bonusPoints, int targetCount) : base(name, summary, points)
    {
        BonusPoints = bonusPoints;
        TargetCount = targetCount;
    }
    
    [JsonConstructor]
    public Checklist(string name, string summary, int points, bool isCompleteCheck, int bonusPoints, int targetCount, int currentCount) : base(name, summary, points)
    {
        IsCompleteCheck = isCompleteCheck;
        BonusPoints = bonusPoints;
        TargetCount = targetCount;
        CurrentCount = currentCount;
    }



    public override int RecordEvent()
    {
        if (IsCompleteCheck)
        {
            Console.WriteLine("This goal is already completed!");
            return 0;
        }

        CurrentCount++;

        if(CurrentCount == TargetCount)
        {
            IsCompleteCheck = true;
            return BonusPoints + Points;
        }
        else
        {
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
        string display = $"{completed} {Name} ({Summary})\n" +
                         $"    -- Completed {CurrentCount}/{TargetCount}\n" +
                         $"    -- {Points} points each time, {BonusPoints} bonus on completion.";
        return display;
    }

}