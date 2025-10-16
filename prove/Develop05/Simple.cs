using System;



public class Simple : Goal
{
    private bool _isComplete;

    public Goal() : base()
    {
        


    }
    
    public override int RecordEvent();

    public override bool IsComplete();

    public override string GetDisplayString();





}