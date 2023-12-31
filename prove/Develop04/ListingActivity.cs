/*
Responsabilities:

    1. The activity should begin with the standard starting message and prompt
       for the duration that is used by all activities.

    2. The description of this activity should be something like: "This activity
       will help you reflect on the good things in your life by having you list
       as many things as you can in a certain area."

    3. After the starting message, select a random prompt to show the user such as:

        · Who are people that you appreciate?
        · What are personal strengths of yours?
        · Who are people that you have helped this week?
        · When have you felt the Holy Ghost this month?
        · Who are some of your personal heroes?

    4. After displaying the prompt, the program should give them a countdown of
       several seconds to begin thinking about the prompt. Then, it should 
       prompt them to keep listing items.

    5. The user lists as many items as they can until they they reach the 
       duration specified by the user at the beginning.

    6. The activity them displays back the number of items that were entered.

    7. The activity should conclude with the standard finishing message for 
       all activities.

Behaviors: 

		• Run the activity
        • Get a random prompt
		• Get a list of responses from the user

			► Run() : void
			► GetRandomPrompt() : string
			► GetListFromUser() : List<string>

Attributes:

        the listing activity should store a count of the number of items listed, 
        and a list of prompts to draw from.

        	► _count : int
			► _prompts : List<string>

Constructors:

    The derived class constructor may be able to set good values in the base 
    class even if you don't pass parameters to it. You could use setters or 
    pass them to the base base class constructor directly.

    The constructors need to initialize the list of prompts and populate them 
    with values.


*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
class ListingActivity : Activity
{
    protected List<string> _prompts;
    protected Random _random = new();

    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    private string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate? ",
            "What are personal strengths of yours? ",
            "Who are people that you have helped this week? ",
            "When have you felt the Holy Ghost this month? ",
            "Who are some of your personal heroes? "
        };

        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }   

        private List<string> GetListFromUser()
        {
            Console.WriteLine("Enter as many items, one by one, in the alloted time. Type 'done' if finished.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            List<string>_responses = new List<string>();

            return _responses;
        }


        public void Run()
        {
            string prompt = GetRandomPrompt();
            Console.Write(prompt);
            ShowSpinner(5);

            Console.WriteLine();
            Console.WriteLine();

            List<string>responses = GetListFromUser();
            string input;
            
            int duration = Duration();


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.Elapsed.TotalSeconds < duration & ((input = Console.ReadLine()) != "done"))
            {
                responses.Add(input);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"You entered {responses.Count} responses in this session.");

            DisplayEndingMessage();

        }

    
}

