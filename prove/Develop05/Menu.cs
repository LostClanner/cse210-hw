using System;
using System.Threading;
using System.Text.Json;
using System.Collections.Generic;


public class Menu
{
    private List<Goal> _goal = new List<Goal>();
    private int _userPoints;


    public void ListGoals()
    {
        int i = 1;
        Console.Clear();
        Console.WriteLine("These are your goals");
        foreach (Goal goal in _goal)
        {
            Console.WriteLine($"--- Goal #{i} ---");
            Console.WriteLine(goal.GetDisplayString());
            i++;
        }
        Console.Write("press enter to continue: ");
        Console.ReadLine();
    }

    public void MakeGoals()
    {
        Console.Clear();
        Console.WriteLine("What type of goal would you like to make?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Bad Habbit");
        Console.Write("Please select 1-3: ");
        string choice = Console.ReadLine();

        Console.Write("What's the name of the goal? ");
        string name = Console.ReadLine();

        Console.Write("How are you going to complete this goal? ");
        string summary = Console.ReadLine();




        switch (choice)
        {
            case 1:
                Console.Write("How many points should the goal be worth? ");
                int points = int.Parse(Console.ReadLine());
                Simple simpleGoal = new Simple(name, summary, points);
                _goal.Add(simpleGoal);
                Console.Clear();
                break;

            case 2:
                Eternal eternalGoal = new Eternal(name, summary);
                _goal.Add(eternalGoal);
                Console.Clear();
                break;

            case 3:
                Console.Write("How many times do you want to complete this goal? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("How many points should you get each time? ");
                int point = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points for completing the whole thing? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                Checklist checklistGoal = new Checklist(name, summary, point, bonusPoints, targetCount);
                _goal.Add(checklistGoal);
                break;

            case 4:
                Console.Write("How many points should the bad habbit subtract? ");
                int minusPoints = int.Parse(Console.ReadLine());
                if(minusPoints > 0)
                {
                    minusPoints = minusPoints * -1;
                }
                HabbitBreaker habbitBreaker = new HabbitBreaker(name, summary, minusPoints);
                _goal.Add(habbitBreaker);
                Console.Clear();
                break;
            
        }



    }
    public void CompleteGoals()
    {
        Console.WriteLine("Which goal did you complete?");
        Thread.Sleep(1000);
        ListGoals();
        Console.Write("Enter the number of the goal");
        int i = int.Parse(Console.ReadLine());
        i--;

        if (i >= 0 && i < _goal.Count)
        {
            Goal selectGoal = _goal[i];
            int pointsScored = selectGoal.RecordEvent();
            _userPoints += pointsScored;

            Console.WriteLine($"You have earned {pointsScored} points!");
            Console.WriteLine($"That brings you total to {_userPoints}!");
        }
        else
        {
            Console.WriteLine("Invalid number");
            Thread.Sleep(1200);
        }
    }



    //https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/overview
    //https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to
    //https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism
    public void SaveGoals()
    {
        Console.WriteLine("What file to you want to save to?\nEX: Goals.json (must be .json)");
        string filename = Console.ReadLine();

        SaveGoals data = new SaveGoals
        {
            UserPoints = _userPoints,
            Goals = _goal
        };

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(data, options);
        File.WriteAllText(filename, jsonString);

        Console.WriteLine($"Saved to {filename}!");
        Thread.Sleep(1200);

    }
    
    public void LoadGoals()
    {
        Console.Write("What file would you like to load from? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            Console.WriteLine("Loading goals from file...");
            string jsonString = File.ReadAllText(filename);
            
            SaveGoals data = JsonSerializer.Deserialize<SaveGoals>(jsonString);

            _userPoints = data.UserPoints;
            _goal = data.Goals; 
            Console.WriteLine("Success! Loaded goals!");
        }
        else
        {
            Console.WriteLine("Error: That file does not exist.");
            Thread.Sleep(1200);
        }
    }
        
    

}
    // public void Run()
    // {


    // }