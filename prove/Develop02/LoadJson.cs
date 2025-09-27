using System;
using System.Threading.Tasks.Dataflow;


public class LoadJson
{
    public string _load(string filename)
    {
        var json = File.ReadAllText(filename);
        return json;
    }
}


