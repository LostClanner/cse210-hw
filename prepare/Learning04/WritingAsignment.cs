using System;


//this says to get the info from the base class
public class WritingAsignment : Asignment
{
    private string _bookTitle;
    private string _author;

    //gets the new info and adds it
    public WritingAsignment(string studentName, string topic, string bookTitle)
        : base(studentName, topic)
    {
        _bookTitle = bookTitle;
        _author = GetStudentsName();


    }

    //gives me the info
    public string GetWritingInfo()
    {
        return $"Book: {_bookTitle}, By: {_author}";

    }

    
}