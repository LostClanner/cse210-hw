using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percentage? ");
        string grade = Console.ReadLine();

        int gradePercentage = int.Parse(grade);
        if (gradePercentage >= 90)
        {
            Console.WriteLine("You got an A! nice!");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("You got a B! Well done, but try a little harder next time.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("You got a C. Hey, at least you passed!");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("You got a D. I think this counts as failing...");
        }
        else
        {
            Console.WriteLine("You got an F. Maybe try the class before again, then take this one again.");
        }

    }
}
