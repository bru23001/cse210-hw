/*
Responsabilities:

    1. The activity should begin with the standard starting message and prompt 
       for the duration that is used by all activities.
    2. The description of this activity should be something like: "This activity
       will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    3. After the starting message, the user is shown a series of messages 
       alternating between "Breathe in..." and "Breathe out..."
    4. After each message, the program should pause for several seconds and 
       show a countdown.
    5. It should continue until it has reached the number of seconds the user 
       specified for the duration.
    6. The activity should conclude with the standard finishing message for all
       activities.

Behaviors: 

	• Run the activity
		► Run() : void

Attributes:

    The Breathing Activity likely does not need any attributes
        ► None needed

Constructors:

    he derived class constructor may be able to set good values in the base 
    class even if you don't pass parameters to it. You could use setters or 
    pass them to the base base class constructor directly.
*/
using System;
using System.Threading;
using System.Diagnostics;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    { 
    }
    public void Run()
    {
        int duration = Duration();
        int partialDuration = duration/8;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();


        Console.Clear();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(partialDuration);
            Console.Clear();

            Console.Write("Breathe out...");
            ShowCountDown(partialDuration);
            Console.Clear();

        }

        DisplayEndingMessage();   
    }
}



