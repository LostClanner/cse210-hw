using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Just a little welcome message
        Console.WriteLine("------------Journal home page------------");
        bool continueProgram = true;
        string myjson = "";

        while (continueProgram)
        {
            //Getiing the user input
            Console.WriteLine("Type a number between 1 and 5 to select an option:");
            Console.WriteLine("Enter 1 to write your journal");
            Console.WriteLine("Enter 2 to display your journal");
            Console.WriteLine("Enter 3 to load your journal file");
            Console.WriteLine("Enter 4 to save your journal");
            Console.WriteLine("Enter 5 to quit");
            int Selection = int.Parse(Console.ReadLine());
            string filename = "";


            //Switch should be a lot better!
            switch (Selection)
            {
                case 1:
                    Console.WriteLine("You selected option 1: Write your journal");
                    // random questions
                    Console.WriteLine("What is on your mind today?");
                    String response = Console.ReadLine();
                    DateTime currentTime = DateTime.Now;
                    Console.WriteLine("Current local time is: " + currentTime);
                    myjson += $"{{\"date\":\"{currentTime}\", \"prompt\":\"What is on your mind today?\", \"response\":\"{response}\"}}";
                    Console.WriteLine("Entry recorded.");
                    Console.WriteLine(myjson);

                    break;
                case 2:
                    Console.WriteLine("You selected option 2: Display your journal");
                    Console.WriteLine("Here is your journal:");
                    Console.WriteLine(myjson);
                    break;
                case 3:
                    Console.WriteLine("You selected option 3: Load your journal file");
                    Console.WriteLine("What is the filename?");
                    filename = Console.ReadLine();
                    LoadJson loadJson = new LoadJson();
                    myjson = loadJson._load(filename);
                    Console.WriteLine("File loaded");

                    break;
                case 4:
                    Console.WriteLine("You selected option 4: Save your journal");
                    Console.WriteLine("What is the filename?");
                    filename = Console.ReadLine();
                    SaveJson saveJson = new SaveJson();
                    saveJson._save(filename, myjson);
                    Console.WriteLine("File saved");
                    break;
                case 5:
                    Console.WriteLine("You selected option 5: Quit");
                    continueProgram = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
    
}