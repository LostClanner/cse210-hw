using System;



public class Checklist : Goal
{
    private bool _isComplete = false;
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount = 0;

    public Checklist(string name, string summary, int points, int bonusPoints, int targetCount) : base(name, summary, points)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
    }
    
    public override int RecordEvent()
    {
        
        if(_currentCount = _targetCount)
        {
            _isComplete = true;
            return _bonusPoints + _points;

        }
        else
        {
            _currentCount++;
            return _points;
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
        string display = $"{completed} {_name}, {_summary}. And it's worth {_points} points!";
        return display;
    }

}