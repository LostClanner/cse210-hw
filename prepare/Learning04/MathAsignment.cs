using System;



public class MathAsignment : Asignment
{
    private string _textbookSection;
    private string _problems;


    public MathAsignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }

    public string GetHomeworkList()
    {
        return $"Selection: {_textbookSection}, Problems: {_problems}";

    }

    
}