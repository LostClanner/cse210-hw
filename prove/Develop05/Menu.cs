using System;


public class Menu
{
    private List<Goal> _goal = new List<Goal>();
    private int _userPoints;


    private void ListGoals()
    {


    }

    private void MakeGoals()
    {
        Console.Clear();
        Console.WriteLine("What type of goal would you like to make?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Please select 1-3");
        string choice = Console.ReadLine();

        //All the goals have this
        Console.WriteLine("What's the name of the goal?\n");
        string name = Console.ReadLine();

        Console.WriteLine("How are you going to complete this goal?\n");
        string summary = Console.ReadLine();

        Console.WriteLine("How many points should the be worth?\n");
        int points = int.parse(Console.ReadLine());

        //this one is case specsific
        switch (choice)
        {
            case "1":
                Simple simpleGoal = new Simple(name, summary, points);
                _goals.Add(simpleGoal);
                break;











        }



    }

    private void CompleteGoals()
    {

    }

    private void SaveGoals()
    {

    }
    
    private void LoadGoals()
    {
        
    }

}
    // public void Run()
    // {


    // }