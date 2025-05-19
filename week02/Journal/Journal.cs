// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;

// In Journal.cs this is where a collection of entries and handles saving/loading to the files.

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine("----------------------------");
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in entries)
        {
            // Using | as a delimiter since commas might appear in text
            writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if(parts.Length == 3)
            {
                entries.Add(new Entry(parts[1], parts[2], parts[0]));
            }
        }
    }
}
