using System;

class Program
{
    static void Main(string[] args)
    {
        Game g1 = new Game();
        Console.WriteLine("Welcome to Uno!");
        Console.WriteLine("----------------");
        Console.WriteLine("Press 1 to start a new game. Press 0 to exit.");
        string choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                Console.WriteLine("How many players would you like to play with?");
                if (int.TryParse(Console.ReadLine(), out int numPlayers))
                    {
                        g1.Run(numPlayers);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of players.");
                    }
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Invalid choice. Exiting.");
                break;
        }

    }
}