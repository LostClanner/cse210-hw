using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int duration = 0;
        int a1Cycles = 0;
        Activity a1 = new BreathingActivity(duration, a1Cycles);
        Activity a2 = new ReflectionActivity(duration);
        Activity a3 = new ListingActivity(duration);

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());


    switch (choice)
        {
            case 1:
                Console.WriteLine("How long, in seconds, would you like for your breathing session?");
                duration = int.Parse(Console.ReadLine());
                Console.WriteLine("How many cycles would you like to do?");
                a1Cycles = int.Parse(Console.ReadLine());
                a1 = new BreathingActivity(duration, a1Cycles);
                a1.Run();
                break;
            case 2:
                Console.WriteLine("How long, in seconds, would you like for your reflection session?");
                duration = int.Parse(Console.ReadLine());
                a2 = new ReflectionActivity(duration);
                a2.Run();
                break;
            case 3:
                Console.WriteLine("How long, in seconds, would you like for your listing session?");
                duration = int.Parse(Console.ReadLine());
                a3 = new ListingActivity(duration);
                a3.Run();
                break;
            case 4:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }

    }
}