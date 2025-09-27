using System;
using System.Threading.Tasks.Dataflow;


public class LoadJson
{
    public string _load(string filename)
    {
        var path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);
        Console.WriteLine("Reading from:" + path);
        var json = File.ReadAllText(path);
        return json;
    }
}


