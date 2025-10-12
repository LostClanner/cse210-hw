using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity a1 = new BreathingActivity();
        ReflectionActivity a2 = new ReflectionActivity();
        ListingActivity a3 = new ListingActivity();

        bool keepRunning = true; //This makes it so that the program continues to run!
        int activityCount = 0; //This is the strech
        while (keepRunning)
        {

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
                    a1 = new BreathingActivity();
                    a1.Run();
                    activityCount++;
                    break;
                case 2:
                    a2 = new ReflectionActivity();
                    a2.Run();
                    activityCount++;
                    break;
                case 3:
                    a3 = new ListingActivity();
                    a3.Run();
                    activityCount++;
                    break;
                case 4:
                    keepRunning = false;
                    Console.WriteLine($"You completed {activityCount} activities!");
                    Thread.Sleep(3000);
                    Console.WriteLine("Goodbye!");

                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Thread.Sleep(2000);
                    break;
            }
        }

    }
}