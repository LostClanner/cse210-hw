using System;
using System.Threading;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;


public class Menu
{
    private List<Goal> _goals = new List<Goal>();
    private int _userPoints;


    public void ListGoals()
    {
        int i = 1;
        Console.Clear();
        Console.WriteLine("These are your goals");
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nYou have no goals yet!");
        }

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"--- Goal #{i} ---");
            Console.WriteLine(goal.GetDisplayString());
            i++;
        }
        
        Console.WriteLine($"You currently have {_userPoints} points!");
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
        Console.WriteLine("4. Bad Habit (this will subtract the points)");

        Console.Write("Please select 1-4: ");
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            choice = -1;
        }

        Console.Write("What's the name of the goal/habit? ");
        string name = Console.ReadLine();

        Console.Write("How are you going to complete this goal? ");
        string summary = Console.ReadLine();

        int points = 0;
        if (choice == 1 || choice == 2 || choice == 4)
        {
            Console.Write("How many points should be attached to the goal? ");
            points = GetValidInteger();
        }




        switch (choice)
        {
            case 1:
                Simple simpleGoal = new Simple(name, summary, points);
                _goals.Add(simpleGoal);
                Console.Clear();
                break;

            case 2:
                Eternal eternalGoal = new Eternal(name, summary, points);
                _goals.Add(eternalGoal);
                Console.Clear();
                break;

            case 3:
                Console.Write("How many points each time? ");
                int checklistPoints = GetValidInteger();
                Console.Write("How many times do you want to complete this goal? ");
                int targetCount = GetValidInteger();
                Console.Write("How many bonus points for completing the whole thing? ");
                int bonusPoints = GetValidInteger();

                Checklist checklistGoal = new Checklist(name, summary, checklistPoints, bonusPoints, targetCount);
                _goals.Add(checklistGoal);
                break;

            case 4:
                HabitBreaker habitBreaker = new HabitBreaker(name, summary, points);
                _goals.Add(habitBreaker);
                Console.Clear();
                break;
            default:
                Console.WriteLine("Invalid response");
                Thread.Sleep(1200);
                break;
            
        }



    }
    public void CompleteGoals()
    {
        Console.WriteLine("Which goal did you complete?");
        Thread.Sleep(1000);
        ListGoals();
        Console.Write("Enter the number of the goal");
        int i = GetValidInteger();
        i--;

        if (i >= 0 && i < _goals.Count)
        {
            Goal selectGoal = _goals[i];
            if (selectGoal.IsComplete())
                {
                    Console.WriteLine("This goal is already complete!");
                    Thread.Sleep(1200);
                    return;
                }
            int pointsScored = selectGoal.RecordEvent();
            _userPoints += pointsScored;

            Console.WriteLine($"You have got {pointsScored} points.");
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

        if (!filename.EndsWith(".json"))
        {
            filename += ".json";
        }

        SaveGoals data = new SaveGoals
        {
            UserPoints = _userPoints,
            Goals = _goals
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

        if (!filename.EndsWith(".json"))
        {
            filename += ".json";
        }

        if (File.Exists(filename))
        {
            Console.WriteLine("Loading goals from file...");
            string jsonString = File.ReadAllText(filename);
            
            try
            {
                SaveGoals data = JsonSerializer.Deserialize<SaveGoals>(jsonString);

                _userPoints = data.UserPoints;
                _goals = data.Goals; 
                Console.WriteLine("Success! Loaded goals!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: Could not load file. {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Error: That file does not exist.");
            Thread.Sleep(1200);
        }
    }
        
    private int GetValidInteger(string prompt = "> ")
    {
        int number;
        bool isValid = false;

        do
        {
            Console.Write(prompt); 
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out number);
            
            if (!isValid)
            {
                Console.WriteLine("That is not a valid number. Please try again.");
            }
        } while (!isValid);

        return number;
    }

}