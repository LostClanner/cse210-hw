using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Journal j1 = new Journal();
        PromptGen pG1 = new PromptGen();
        bool contineRun = true;

        Console.WriteLine("--------Welcome to the journal--------");

        while (contineRun)
        {
            Console.WriteLine("Pick a number between 1-5 to select an option");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display your journal");
            Console.WriteLine("3. load a file");
            Console.WriteLine("4. save to a file");
            Console.WriteLine("5. quit");
            Console.Write("please choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Your prompt to write");
                    string randomPrompt = pG1.GeneratePrompt();
                    Console.WriteLine(randomPrompt);
                    Console.Write(">");
                    string response = Console.ReadLine();

                    j1.AddNewEntry(randomPrompt, response);
                    break;

                case "2":
                    Console.WriteLine("Your journal: ");
                    j1.DisplayEntry();
                    break;
                case "3":
                    Console.Write("What is the file you want to load: ");
                    string filename = Console.ReadLine();
                    j1.LoadEntry(filename);
                    break;
                case "4":
                case "5":
                default:
                    Console.WriteLine("Error invalid response");
                    break;
            }















        }
    }
}