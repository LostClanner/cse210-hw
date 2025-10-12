using System;
using System.Reflection;
using System.Runtime.CompilerServices;


public class ListingActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    List<string> userList = new List<string>();



    private static Random _random = new Random();





    public ListingActivity()
        : base("listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    public override void Run()
    {
        StartActivity();
        Console.WriteLine("Get ready to list...");
        GetRandomPrompt();
        Console.WriteLine("\nStart listing items in:");
        ShowCountdown(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);



        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            userList.Add(item);

        }

        Console.WriteLine($"You listed {userList.Count} items!");
        LogCount();
        EndActivity();
    }

    private void GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine(randomPrompt);

    }

}