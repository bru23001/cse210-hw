/*
Behaviors:

    • Displaying the starting message
    • Displaying the ending message
    • Pausing while showing a spinner for a certain number of seconds
    • Pausing while showing a countdown timer for a certain number of seconds

        ► DisplayStartingMessage() : void
        ► DisplayEndingMessage() : void
        ► ShowSpinner(seconds : int) : void
        ► ShowCountDown(second : int) : void

Attributes:

    • The activity name
    • The description
    • The duration in seconds

        ► _name : string
        ► _description : string
        ► _duration : int

Constructors:

    The base class will need to initialize all of its member variables. You 
    might require them to be passed in as parameters or you might have a 
    constructor that sets some/all to default values to be changed later.
    You could use setters or pass them to the base base class constructor 
    directly.

*/
using System;
using System.Threading;
using System.Diagnostics;

class Activity
{
    protected string _name;
    protected string _description;
    public int _duration = 0;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Starting {_name} activity. {_description}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Enter the duration in seconds: ");

        _duration = int.Parse(Console.ReadLine());

        int seconds = 5;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        while (seconds > 0)
        {
            Console.Write($"We'll begin in {seconds} seconds... ");
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth - 1));
            Console.SetCursorPosition(0, Console.CursorTop);
            seconds--;
        }    
    }   

    public int Duration()
    {
        return _duration;
    }
    public void ShowCountDown(int partialDuration)
    {
        
        for (int i = partialDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }

    public void ShowSpinner()    
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < 5)
        {
            Console.Write("|"); 
            Thread.Sleep(100);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");

        }
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");

    }
}