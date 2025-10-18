using System;
using System.Runtime.CompilerServices;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        int choice = -1;
        Menu testMenu = new Menu();

        while (isRunning)
        {
            Console.WriteLine("Welcome to Goal Setter Quest");
            Console.WriteLine("Please select what you would like to do");
            Console.WriteLine("1. Make a new goal");
            Console.WriteLine("2. List all of your goals");
            Console.WriteLine("3. Mark a goal complete");
            Console.WriteLine("0. Quit ");
            Console.Write("> ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    testMenu.MakeGoals();
                    break;

                case 2:
                    testMenu.ListGoals();
                    break;

                case 3:
                    testMenu.CompleteGoals();
                    break;

                case 0:
                    isRunning = false;
                    Console.WriteLine("Have a great day!");
                    Thread.Sleep(1200);
                    break;

                default:
                    Console.WriteLine("Incorrect answer, please type a real number");
                    Thread.Sleep(3000);
                    break;
            }


        }

    }
}