using System;



public class WritingAsignment : Asignment
{
    private string _bookTitle;
    private string _author;


    public WritingAsignment(string studentName, string topic, string bookTitle)
        : base(studentName, topic)
    {
        _bookTitle = bookTitle;
        _author = GetStudentsName();


    }

    public string GetWritingInfo()
    {
        return $"Book: {_bookTitle}, By: {_author}";

    }

    
}