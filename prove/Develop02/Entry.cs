using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


public class Entry
{
    public string prompt;
    public string date;
    public string entry;

    public void SaveTo()
    {
        using(StreamWriter writetext = new StreamWriter("entry.txt"))

            {
                writetext.WriteLine($"{date}");
                writetext.WriteLine($"{prompt}");
                writetext.WriteLine($"{entry}");
            }
    }

}
