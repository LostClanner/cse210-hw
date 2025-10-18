using System;
using System.Threading;


public class Menu
{
    private List<Goal> _goal = new List<Goal>();
    private int _userPoints;


    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("These are your goals");
        foreach (Goal goal in _goal)
        {
            Console.WriteLine(goal.GetDisplayString());
            Thread.Sleep(1200);
        }
    }

    public void MakeGoals()
    {
        Console.Clear();
        Console.WriteLine("What type of goal would you like to make?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Please select 1-3: ");
        string choice = Console.ReadLine();

        Console.Write("What's the name of the goal? ");
        string name = Console.ReadLine();

        Console.Write("How are you going to complete this goal? ");
        string summary = Console.ReadLine();




        //this one is case specsific
        switch (choice)
        {
            case "1":

                Console.Write("How many points should the goal be worth? ");
                int points = int.Parse(Console.ReadLine());
                Simple simpleGoal = new Simple(name, summary, points);
                _goal.Add(simpleGoal);
                Console.Clear();
                break;

            case "2":
                Eternal eternalGoal = new Eternal(name, summary);
                _goal.Add(eternalGoal);
                Console.Clear();
                break;
            // case "3":
            //     Checklist checklistGoal = new Checklist(name, summary, points, );
            //     _goal.Add(checklistGoal);
            //     break;
            
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