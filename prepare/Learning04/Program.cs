using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Gets the first set of names
        Console.WriteLine("What's your name: ");
        string usersName = Console.ReadLine();

        //gets the first subject
        Console.WriteLine("What subject are you studying: ");
        string usersSubject = Console.ReadLine();
        
        Console.WriteLine(""); //creates a blank line


        Asignment a1 = new Asignment(usersName, usersSubject);
        Console.WriteLine(a1.GetSummary());

        Console.WriteLine(""); // blank line

        //this is the mathasigmnet
        MathAsignment a2 = new MathAsignment(usersName, "Math", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());


        Console.WriteLine(""); //blank line

        //this is the writing asignment
        WritingAsignment a3 = new WritingAsignment("Martha Steward", "French", "20th Century French Poetry");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());



    }
}