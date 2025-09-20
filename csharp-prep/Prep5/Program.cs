using System;
using System.ComponentModel.DataAnnotations;

/*
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. This function does not return a value. The user's birth year is given back from the function via the out parameter.
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.
Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

Sample output of the program could look as follows:

Welcome to the program!
Please enter your name: Brother Burton
Please enter your favorite number: 42
Please enter the year you were born: 1990
Brother Burton, the square of your number is 1764
Brother Burton, you will turn 35 this year.
*/




class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();


        string UserName = PromptUserName();
        //Console.WriteLine($"test {UserName}");


        int UserNumber = PromptUserNumber();
        //Console.WriteLine($"test {UserNumber}");


        int UserBirthYear = ProntUserBirthYear();
        //Console.WriteLine($"test {UserBirthYear}");


        int SquareNumber = UserSquareNumber(UserNumber);
        //Console.WriteLine($"test {SquareNumber}");


        DisplayResult(UserName, UserBirthYear, SquareNumber);

    }


    // Welcome message function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    // Get the User's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string InputName = Console.ReadLine();
        return InputName;

    }

    // Get the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int InputNumber = int.Parse(Console.ReadLine());
        return InputNumber;
    }

    //Get the user's birth year
    static int ProntUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        int InputBirthYear = int.Parse(Console.ReadLine());
        return InputBirthYear;
    }

    //Squares the users number
    static int UserSquareNumber(int UserNumber)
    {
        int SquaredNumber = UserNumber * UserNumber;
        return SquaredNumber;
    }


    //Display the results
    static void DisplayResult(string UserName, int UserBirthYear, int SquareNumber)
    {
        Console.WriteLine($"{UserName} the square of your number is {SquareNumber}");
        Console.WriteLine($"{UserName} you will turn {2025 - UserBirthYear} this year.");

    }

}