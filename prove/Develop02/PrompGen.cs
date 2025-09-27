using System;

public class PromptGen
{

    string randomPrompt = "";
    public string _generatePrompt()
    {
        var rnd = new Random();
        int promptNumber = rnd.Next(1, 11); // Generates a number between 1 and 10

        if (promptNumber == 1)
        {
            randomPrompt = "Who was the most interesting person I interacted with today?";
        }
        else if (promptNumber == 2)
        {
            randomPrompt = "What was the best part of my day?";
        }
        else if (promptNumber == 3)
        {
            randomPrompt = "How did I see the hand of the Lord in my life today?";
        }
        else if (promptNumber == 4)
        {
            randomPrompt = "What was the strongest emotion I felt today?";
        }
        else if (promptNumber == 5)
        {
            randomPrompt = "If I had one thing I could do over today, what would it be?";
        }
        else if (promptNumber == 6)
        {
            randomPrompt = "What is something new I learned today?";
        }
        else if (promptNumber == 7)
        {
            randomPrompt = "What is a challenge I faced today and how did I overcome it?";
        }
        else if (promptNumber == 8)
        {
            randomPrompt = "What is something I am grateful for today?";
        }
        else if (promptNumber == 9)
        {
            randomPrompt = "What is a goal I have for tomorrow?";
        }
        else if (promptNumber == 10)
        {
            randomPrompt = "What is something kind I did for someone else today?";
        }
        else
        {
            randomPrompt = "Error: Invalid prompt number.";
        }
        
        return randomPrompt;
    }
}