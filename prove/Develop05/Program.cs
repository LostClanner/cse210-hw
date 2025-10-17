using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        int choice = -1;

        while (isRunning)
        {
            Console.WriteLine("Welcome to Goal Setter Quest");
            Console.WriteLine("Please select what you would like to do");
            Console.WriteLine("1. Make a new goal");
            Console.WriteLine("2. List all of your goals");
            Console.WriteLine("0. Quit ");
            Console.Write("> ");

            switch (choice)
            {
                case 1:
                    MakeGoals();
                    break;

                case 2:

                case 0:

                default:
                    Console.WriteLine("Incorrect answer, please type a real number");
                    Thread.Sleep(3000);
                    break;
            }


        }

    }
}