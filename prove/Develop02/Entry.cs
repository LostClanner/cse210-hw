using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;


public class Entry{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public override string ToString()
    {
        return $"Date: {Date:yyyy-MM-dd HH:mm}\nPrompt: {Prompt}\nResponse: {Response}\n--------------------";
    }

}