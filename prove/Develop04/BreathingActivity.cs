using System;
using System.Runtime.CompilerServices;


public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
    }
    public override void Run()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in ");
            ShowCountdown(5);
            Console.WriteLine();

            if (DateTime.Now >= endTime) break;

            Console.Write("Breath out ");
            ShowCountdown(5);
            Console.WriteLine();

        }
        EndActivity();
    }
}