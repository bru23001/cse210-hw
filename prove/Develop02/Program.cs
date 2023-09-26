using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Create a Journal object
Journal journal = new();
// Create a PromptGenerator object
PromptGenerator promptGenerator = new();
// Create an Entry object
Entry entrada = new();
// Create a string variable to store the user's choice
int userOption;
// Create a string variable to store the file name
string file;
// Create a boolean variable to control the loop
bool brexit = false;
// Display a welcome message
Console.WriteLine("Welcome to your personal journal!");
Console.WriteLine();



while (!brexit)
{
    // Menu of options
    Console.WriteLine("Menu Options");
    Console.WriteLine("Write New Entry > 1");
    Console.WriteLine("Display Journal > 2");
    Console.WriteLine("Save Journal    > 3");
    Console.WriteLine("Load Journal    > 4");
    Console.WriteLine("Exit            > 0");
    Console.WriteLine();
    Console.Write("Enter Option: ");

    userOption = int.Parse(Console.ReadLine());

    // iteration through the options
    if (userOption == 1)
    {
        // new entry instance of Entry class---------------------
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        string promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine(promptText);
        Console.WriteLine("> ");
        string entryText = Console.ReadLine();
        entrada = new Entry(date, promptText, entryText);

        // adding entry to the journal
        journal.AddEntry(entrada);
        Console.WriteLine("Your entry has been saved");
    }

    else if (userOption == 2)
    {
        // display instance of Journal class----------------------
        journal.DisplayAll();

    }

    else if (userOption == 3)
    {
        // save entries to a file instance of Save class----------
        Console.WriteLine("Enter filename: ");
        file = Console.ReadLine();
        journal.SaveToFile(file);
        Console.WriteLine("Your journal has been saved");
    }

    else if (userOption == 4)
    {
        Console.WriteLine("Enter filename: ");
        file = Console.ReadLine();
        journal.LoadFromFile(file);
    }

    else if (userOption == 0)
    {
        // exit program-----------------------------------------
        brexit = true;
    }

    else
    {
        Console.WriteLine("Invalid Option");

    }


}
