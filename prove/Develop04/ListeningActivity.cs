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





    public ListingActivity(int duration)
        : base("listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
    }
    public override void Run()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        GetRandomPrompt();
        ShowSpinner(7);
        Console.WriteLine("\nStart listing items now:");

        while(DateTime.Now < endTime)
        {
            GetRandomPrompt();
            ShowCountdown(10);
            string item = Console.ReadLine();
            userList.Add(item);
            
        }

        EndActivity();
    }

    private void GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine(randomPrompt);

    }





}