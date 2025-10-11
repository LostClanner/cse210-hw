using System;
using System.Runtime.CompilerServices;


public class BreathingActivity : Activity
{
    private int _cycles;
    public BreathingActivity(int duration, int cycles)
        : base("box breathing", "You will hold you breath to the prompts!", duration)
    {
        _cycles = cycles;
    }
    public override void Run()
    {
    StartActivity();

        for (int i = _cycles; i > 0; --i)
        {
            Console.Write("Breath in ");
            ShowCountdown(_duration);
            Console.Clear();

            Console.Write("Hold ");
            ShowCountdown(_duration);
            Console.Clear();

            Console.Write("Breath out ");
            ShowCountdown(_duration);
            Console.Clear();

            Console.Write("Hold ");
            ShowCountdown(_duration);
            Console.Clear();

        }
        EndActivity();
    }
}