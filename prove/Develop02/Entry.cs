// Represents a single journal entry.

// RESPONSABILITY: main responsability is to hold data, have it's own display 
// method. 

// BEHAVIOR: Then the Journal display method could iterate through all Entry 
// objects and call the Entry display method. The Journal wouldn't have to 
// worry about the details of how the Entry was displayed, this would all be 
// contained within the Entry class.

// ATRIBUTE: An Entry should keep track of the date, prompt text, and the text 
// of the entry itself.
// _date : string
// _promptText : string
// _entryText : string

// METHOD: Display() : void

using System;

class Entry
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
}