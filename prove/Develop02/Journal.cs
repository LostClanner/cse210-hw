using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }


    public void AddNewEntry(string prompt, string response)
    {
        Entry newEntry = new Entry
        {
            Date = DateTime.Now,
            Prompt = prompt,
            Response = response
        };
        _entries.Add(newEntry);
        Console.WriteLine("That entry was recorded");
        

    }

    public void DisplayEntry()
    {
        if(_entries.Count == 0)
        {
            Console.WriteLine("There are no entries to display.");
        }
        else
        {
            Console.WriteLine("This is your journal: ");
            foreach(Entry entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

    }

    public void SaveEntry()
    {

    }
    
    public void LoadEntry()
    {
        
    }

    // add display save load 

}