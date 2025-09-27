using System;
using System.Threading.Tasks.Dataflow;

//This class will load the json file and return it
public class LoadJson
{
    public string _load(string filename)
    {
        //The way I found for finding the file
        var path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);
        Console.WriteLine("Reading from:" + path);
        var json = File.ReadAllText(path);
        return json;
    }
}


