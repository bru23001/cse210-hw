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
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Entry class: Represents a single journal entry.
public class Entry
{
    // ATRIBUTES==============================================================
    private string  _date; 
    private string _promptText; 
    private string _entryText; 

    // BEHAVIOR================================================================
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    // METHOD===================================================================
    // Displays the entry in a formatted way 
    public void Display()
    {
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Entry: " + _entryText);
        Console.WriteLine();
    }
    // Returns a string representation of the entry using '|' as a separator
    public string TodayEntry()
    {
        string entrada = $"{_date} | {_promptText} | {_entryText}";
        return entrada;
    }




}
