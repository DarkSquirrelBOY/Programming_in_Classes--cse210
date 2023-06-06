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
        using(StreamWriter writetext = new StreamWriter("entry.txt", true))

            {
                writetext.WriteLine($"--{date}--");
                writetext.WriteLine($"{prompt}");
                writetext.WriteLine("");               
                writetext.WriteLine($"{entry}");
                writetext.WriteLine("");
            }
    }

    public void LoadEntry()
    {
        var linesRead = File.ReadLines("entry.txt");

        // iterate through each element within the array and
        // print it out
        //
        foreach (var lineRead in linesRead)
        {
            Console.WriteLine(lineRead);
        }
        // using(StreamReader readtext = new StreamReader("entry.txt"))
        // {
        //     string[] files = Directory.GetFiles("entry.txt");
        //     // List<string> result = new List<string>();
        //     string[] lines = File.ReadAllLines("entry.txt");

        //     Console.WriteLine(lines[0]);
        //     Console.WriteLine(lines[1]);
        //     Console.WriteLine(lines[2]);

            // foreach (string line in result)
            // {
            //     string[] lines = File.ReadAllLines(line);

            //     // Grab information from the lines and store it in result
            //     // by using result.Add(...) or result.AddRange(...)
            //     Console.WriteLine(lines[0]);
            //     Console.WriteLine(lines[1]);
            //     Console.WriteLine(lines[2]);
            // }

            // File.WriteAllLines("entry.txt", result);
            
        
    }
}
