using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //string usersName = "";
        //string usersSubject = "";


        Console.WriteLine("What's your name: ");
        string usersName = Console.ReadLine();

        Console.WriteLine("What subject are you studying: ");
        string usersSubject = Console.ReadLine();

        Asignment a1 = new Asignment(usersName, usersSubject);
        Console.WriteLine(a1.GetSummary());

        MathAsignment a2 = new MathAsignment(usersName, "Math", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAsignment a3 = new WritingAsignment("Martha Steward", "French", "20th Century French Poetry");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());



    }
}