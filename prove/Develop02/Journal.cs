using System.IO;
using System;
using System.Collections.Generic;

public class Journal
{
    Journal theJournal = new Journal();

    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine(Entry._promptText);
        Console.Write("> ");
        Entry._entryText = Console.ReadLine();
        Entry.add(Entry._date, Entry._promptText, _response);
    }

    public void DisplayAll()
    {
        foreach (entry e in _entries)
        {
            Entry.Display();
        }
    }

    public void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine("Please enter the name you would like to save the file as: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
        {
            outputFile.WriteLine(e);
        }
        }

        Console.WriteLine($"File saved as {fileName}. ");
    }

    public void LoadFromFile(string file)
    {

    }
}