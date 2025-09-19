using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percentage? ");
        string grade = Console.ReadLine();
        string letterGrade = "F";
        bool passingGrade = false;

        //This part goes throught which grade people got
        int gradePercentage = int.Parse(grade);
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
            passingGrade = true;
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
            passingGrade = true;
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
            passingGrade = true;
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        
        else
        {
            letterGrade = "F";
        }
        
        Console.WriteLine($"Your letter grade is: {letterGrade}");


        // This part displays if the student passed or failed
        if (passingGrade)
        {
            Console.WriteLine("Congratulations! You are passing the class!");
        }
        else  
        {
            Console.WriteLine("Unfortunately, you have failed the class.");
        }

        }

}
