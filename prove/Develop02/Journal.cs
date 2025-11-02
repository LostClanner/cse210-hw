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

    public void SaveEntry(string filename)
    {
        try
        {
            var path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);
            Console.WriteLine($"Saving to: {path}");
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(_entries, options);

            File.WriteAllText(path, jsonString);
            Console.WriteLine("File saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }

    }
    
    public void LoadEntry(string filename)
    {
        try
        {
            var path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found.");
                return;
            }
            Console.WriteLine($"Reading from: {path}");
            string jsonString = File.ReadAllText(path);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            Console.WriteLine("File loaded successfully.");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error parsing JSON file. The file might be corrupt or in the wrong format: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
        
    }
}