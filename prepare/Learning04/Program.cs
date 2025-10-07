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

        MathAsignment a2 = new MathAsignment(usersName, usersSubject, "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

    }
}