using System;
using System.Threading.Tasks.Dataflow;


public class SaveJson
{
    void Save(string filename, string myjson)
    {
        var path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);

        File.WriteAllText(path, myjson);
    }
}




Write ask random prompt
Display json
Load ask for filename
Save ask for filenanme
Quit