using System;


//this is a base class
public class Asignment
{
    private string _studentName = "";
    private string _topic = "";


    //this is the base info we need
    public Asignment(string StudentName, string Topic)
    {
        _studentName = StudentName;
        _topic = Topic;
    }

    //this this gives all all the subclasses this info
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    //this is just for the students name
    public string GetStudentsName()
    {
        return _studentName;
    }

    /*
        --this was for getting just the topic, but it was never used--

    public string GetTopic()
    {
        return _topic;
    }
    */
}