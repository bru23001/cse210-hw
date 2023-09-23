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

class Journal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
}