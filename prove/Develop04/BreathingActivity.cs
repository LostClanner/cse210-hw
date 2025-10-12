using System;
using System.Runtime.CompilerServices;


public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", duration)
    {
    }
    public override void Run()
    {
    StartActivity();

        for (int i = _duration; i > 0; --i)
        {
            Console.Write("Breath in ");
            ShowCountdown(5);
            Console.Clear();

            Console.Write("Breath out ");
            ShowCountdown(5);
            Console.Clear();

        }
        EndActivity();
    }
}