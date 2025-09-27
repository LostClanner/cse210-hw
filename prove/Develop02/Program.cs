using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Just a little welcome message
        Console.WriteLine("------------Journal home page------------");



        Write
        Display
        Load
        Save
        Quite 
    


        //Getiing the user input
        Console.WriteLine("Type a number between 1 and 5 to select an option:");
        Console.WriteLine("Enter 1 to write your journal");
        Console.WriteLine("Enter 2 to display your journal");
        Console.WriteLine("Enter 3 to load your journal file");
        Console.WriteLine("Enter 4 to save your journal");
        Console.WriteLine("Enter 5 to quit");
        int Selection = int.Parse(Console.ReadLine());

        string myjson=  "";
        string filename = "";   

        //Switch should be a lot better!
        switch (Selection)
        {
            case 1:
                Console.WriteLine("You selected option 1: Write your journal");
                // random questions

                break;
            case 2:
                Console.WriteLine("You selected option 2: Display your journal");
                Console.WriteLine(myjson);
                break;
            case 3:
                Console.WriteLine("You selected option 3: Load your journal file");
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                LoadJson loadJson = new LoadJson();
                myjson = loadJson._load(filename);

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