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
class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    { 
        
       public void Run()
        {
            DisplayStartingMessage();
            ShowSpinner();

            for (int i = 0; i < _duration; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Breathe in...");
                    ShowCountDown(_duration);
                }
                else
                {
                    Console.WriteLine("Breathe out...");
                }
                ShowCountDown(1); // Pause for 1 second
            }
            DisplayEndingMessage();
        }
    }
}

