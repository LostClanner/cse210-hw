using System;

class Program
{
    static void Main(string[] args)
    {

        /*

        What will be the the random number!
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        */
        // this is going to be our test number
        int magicNumber = 36;


        Console.WriteLine("Welcome to guess the magic number!");
        Console.Write("Let's get started. what is your guess for the magic number? ");
        string firstGuess = Console.ReadLine();
        int guess = int.Parse(firstGuess);

        if (guess < magicNumber)
        {
            Console.WriteLine("You guessed under the number");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("You guessed over the number");
        }
        else
        {
            Console.WriteLine("That was the magic number! Congrats!");
        }

    }
}