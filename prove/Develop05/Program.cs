using System;
using System.Runtime.CompilerServices;
using System.Threading;
//Added a negitive goal to help people break bad habbits
//That is for the strech goal
class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        Menu testMenu = new Menu();

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Goal Setter Quest");

            Console.WriteLine("Please select what you would like to do");
            Console.WriteLine("1. Make a new goal");
            Console.WriteLine("2. List all of your goals");
            Console.WriteLine("3. Mark a goal complete");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("0. Quit ");
            Console.Write("> ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

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
                case 4:
                    testMenu.LoadGoals();
                    break;
                case 5:
                    testMenu.SaveGoals();
                    break;

                case 0:
                    isRunning = false;
                    Console.WriteLine("Have a great day!");
                    Thread.Sleep(1200);
                    break;

                default:
                    Console.WriteLine("Incorrect answer, please type a real number");
                    Thread.Sleep(2000);
                    break;
            }


        }

    }
}