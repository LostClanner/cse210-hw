using System;
using System.Threading.Tasks.Dataflow;


public class SaveJson
{
    public void _save(string filename, string myjson)
    {
        var path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);
        Console.WriteLine("Saving to:");
        Console.WriteLine(path);    

        File.WriteAllText(path, myjson);
    }
}

