using System;


//gets from the base class
public class MathAsignment : Asignment
{
    private string _textbookSection;
    private string _problems;


    //Gets the new info and adds it
    public MathAsignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }

    //this gives me the info
    public string GetHomeworkList()
    {
        return $"Selection: {_textbookSection}, Problems: {_problems}";

    }

    
}