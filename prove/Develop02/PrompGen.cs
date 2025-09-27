using System;

public class PrompGen
{
    int GeneratePrompt()
    {
        var rnd = new Random();
        int promptNumber = rnd.Next(1, 11); // Generates a number between 1 and 10
        return promptNumber;
    }
}