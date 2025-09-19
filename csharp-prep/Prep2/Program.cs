using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percentage? ");
        string grade = Console.ReadLine();
        bool passingGrade = false;

        //This part goes throught which grade people got
        int gradePercentage = int.Parse(grade);
        if (gradePercentage >= 90)
        {
            Console.WriteLine("You got an A! nice!");
            passingGrade = true;
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("You got a B! Well done, but try a little harder next time.");
            passingGrade = true;
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("You got a C. Hey, at least you passed!");
            passingGrade = true;
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("You got a D... enjoy taking this class again.");
        }
        else
        {
            Console.WriteLine("You got an F. Maybe try the class before again, then take this one again.");
        }

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
