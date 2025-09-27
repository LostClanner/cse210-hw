using System;

class Program
{
    static void Main(string[] args)
    {
        //Just a little welcome message
        Console.WriteLine("------------Journal home page------------");


        //Getiing the user input
        Console.WriteLine("Type a number between 1 and 5 to select an option:");
        Console.WriteLine("Enter 1 to view your journal");
        Console.WriteLine("Enter 2 to add a new entry");
        Console.WriteLine("Enter 3 to load your journal file");
        Console.WriteLine("Enter 4 to save your journal");
        Console.WriteLine("Enter 5 to quit");
        int Selection = int.Parse(Console.ReadLine());


        //Switch should be a lot better!
        switch (Selection)
        {
            case 1:
                Console.WriteLine("You selected option 1: View your journal");
                break;
            case 2:
                Console.WriteLine("You selected option 2: Add a new entry");
                break;
            case 3:
                Console.WriteLine("You selected option 3: Load your journal file");
                break;
            case 4:
                Console.WriteLine("You selected option 4: Save your journal");
                break;
            case 5:
                Console.WriteLine("You selected option 5: Quit");
                break;
            default:
                Console.WriteLine("Invalid selection. Please enter a number between 1 and 5.");
                break;
        }
        

        
        

    }
    
}