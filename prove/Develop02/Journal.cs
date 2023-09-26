// RESPONSABILITY: Stores a list of journal entries.

// BEHAVIORS: Adding entry, displaying all entries, saving to a file, loading 
// from a file. Using this design, when you want to add a new entry to the 
// journal, you will use code such as theJournal.AddEntry(anEntry); instead 
// of using the _entries variable and its add method like this 
// theJournal._entries.Add(anEntry)

// ATRIBUTES: A Journal should store a list of Entry objects. The data type 
// for this should be List<Entry>
// _entries : List<Entry>

// METHODS: 
// AddEntry(newEntry : Entry) : void
// DisplayAll() : void
// SaveToFile(file : string)
// LoadFromFile(file : string)

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Journal
{
    private readonly List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    // Adds a new entry to the _entries list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entrada in _entries)
        {
          entrada.Display();  
        }
    }

    // Saves the _entries list to a file using StreamWriter
    public void SaveToFile(string file)
    {
        if (string.IsNullOrEmpty(file))
        {
            Console.WriteLine("Invalid file name.");
            return;
        }
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entrada in _entries)
            {
                outputFile.WriteLine(entrada.TodayEntry());
            }
        }    
    }
    // Loads the _entries list from a file using StreamReader
    public void LoadFromFile(string file)
    {
        if (string.IsNullOrEmpty(file))
        {
           Console.WriteLine("Invalid file name.");
           return; 
        }

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }
        using (StreamReader inputFile = new StreamReader(file))
        {
            string line;
            while ((line = inputFile.ReadLine()) !=null)
            {
                string[] parts = line.Split(" | ");
                if (parts.Length == 3)
                {
                    Entry entrada = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entrada);
                }
            }
        }
    }
 




}