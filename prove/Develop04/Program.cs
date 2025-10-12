using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int duration = 0;
        Activity a1 = new BreathingActivity(duration);
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
                a1 = new BreathingActivity(0);
                a1.Run();
                break;
            case 2:
                a2 = new ReflectionActivity(0);
                a2.Run();
                break;
            case 3:
                a3 = new ListingActivity(0);
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