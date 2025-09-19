using System;

class Program
{
    static void Main(string[] args)
    {



        //What will be the the random number!
        // we now will make it our random number
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guessAmount = 0;


        /* this is going to be our test number
        we no longer use this
        int magicNumber = 36;
        */

        Console.WriteLine("Welcome to guess the magic number!");
        Console.Write("Let's get started. what is your guess for the magic number? ");
        string firstGuess = Console.ReadLine();
        int guess = int.Parse(firstGuess);


        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine($"{guess} is too low");
                Console.WriteLine(""); // this makes it clearer to read
                guessAmount += 1;
            }
            else
            {
                Console.WriteLine($"{guess} is too high");
                Console.WriteLine(""); //this make it clearer to read
                guessAmount += 1;

            }
            Console.Write("What is your next guess? ");
            string nextGuess = Console.ReadLine();
            guess = int.Parse(nextGuess);
        }

        Console.WriteLine("That was the Magic Number! Congrats!");
        Console.WriteLine($"It took you {guessAmount} tries to find the magic number!");




        /*
                   This is the old system for the guesser
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

        */

    }
}