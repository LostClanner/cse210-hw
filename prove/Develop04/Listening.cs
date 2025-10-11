using System;
using System.Reflection;
using System.Runtime.CompilerServices;


public class ReflectionActivity : Activity
{

    public ReflectionActivity(int duration)
        : base("reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {

    }
    public override void Run()
    {
        StartActivity();

        EndActivity();
    }
    

    








}