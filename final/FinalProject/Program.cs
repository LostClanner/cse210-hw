using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Uno!");
            Console.WriteLine("----------------");
            Console.WriteLine("Press 1 to start a new game. Press 0 to exit.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Game g1 = new Game(); 

                    Console.WriteLine("How many players would you like to play with?");
                    if (int.TryParse(Console.ReadLine(), out int numPlayers))
                    {
                        if (numPlayers > 1 && numPlayers < 10)
                        {
                            g1.Run(numPlayers);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number of players. (Must be 2-9)");
                            Console.WriteLine("Press enter to return to menu.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("Press enter to return to menu.");
                        Console.ReadLine();
                    }
                    break;
                case "0":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    Console.WriteLine("Press enter to return to menu.");
                    Console.ReadLine();
                    break;
            }
        }

    }
}