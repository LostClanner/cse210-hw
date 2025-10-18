using System;
using System.Text.Json.Serialization;



public class Checklist : Goal
{
    private bool _isComplete = false;
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount = 0;
    [JsonConstructor]
    public Checklist(string name, string summary, int points, int bonusPoints, int targetCount) : base(name, summary, points)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
    }
    
    public override int RecordEvent()
    {
        
        if(_currentCount == _targetCount)
        {
            _isComplete = true;
            return _bonusPoints + Points;

        }
        else
        {
            _currentCount++;
            return Points;
        }
        
        
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
        string display = $"{completed} {Name}, {Summary}. And it's worth {Points} points! Plus {_bonusPoints} bonus points!\nYou have completed the goal {_currentCount}/{_targetCount}";
        return display;
    }

}