using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class PromptGen
{

    private List<string> _prompts;
    private Random _random;

    public PromptGen()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "What is a challenge I faced today and how did I overcome it?",
            "What is something I am grateful for today?",
            "What is a goal I have for tomorrow?",
            "What is something kind I did for someone else today?"
        };
    }



}