/*
Responsabilities:

    1. The activity should begin with the standard starting message and prompt 
       for the duration that is used by all activities.

    2. The description of this activity should be something like: "This activity
       will help you reflect on times in your life when you have shown strength
       and resilience. This will help you recognize the power you have and how 
       you can use it in other aspects of your life."

    3. After the starting message, select a random prompt to show the user such as:

        · Think of a time when you stood up for someone else.
        · Think of a time when you did something really difficult.
        · Think of a time when you helped someone in need.
        · Think of a time when you did something truly selfless.

    4. After displaying the prompt, the program should ask the to reflect on 
       questions that relate to this experience. These questions should be 
       pulled from a list such as the following:

        · Why was this experience meaningful to you?
        · Have you ever done anything like this before?
        · How did you get started?
        · How did you feel when it was complete?
        · What made this time different than other times when you were not as successful?
        · What is your favorite thing about this experience?
        · What could you learn from this experience that applies to other situations?
        · What did you learn about yourself through this experience?
        · How can you keep this experience in mind in the future?

    5. After each question the program should pause for several seconds before 
       continuing to the next one. While the program is paused it should display
       a kind of spinner.

    6. It should continue showing random questions until it has reached the 
       number of seconds the user specified for the duration.

    7. The activity should conclude with the standard finishing message for all
       activities.

Behaviors: 

		• Run the activity
        ○ Get a random prompt to show
		○ Get a random question about the prompt
		○ Display the prompt
		○ Display questions about the prompt and get answers

			► Run() : void
			► GetRandomPrompt() : string
			► GetRandomQuestion() : string
			► DisplayPrompt() : void
			► DisplayQuestions() : void

Attributes:

        should store a list of questions and a list of prompts to draw from.

        	► _prompts : List<string>
			► _questions : List<string>

Constructors:

    the derived class constructor may be able to set good values in the base 
    class even if you don't pass parameters to it.
*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Diagnostics;
class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;
    protected Random _random = new();
    public ReflectingActivity(string name, string description) : base (name, description)
	{
    }    
        
    private string GetRandomPrompt()
    {
        _prompts = new List<string>
         {
            "Think of a time when you stood up for someone else. ",
            "Think of a time when you did something really difficult. ",
            "Think of a time when you helped someone in need. ",
            "Think of a time when you did something truly selfless. "
        };
        int index = _random.Next(_prompts.Count);
        return _prompts[index];

    }   

    private string GetRandomQuestion()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };
        int index = _random.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }  
    public void Run()
    {

        string prompt = GetRandomPrompt();
        Console.WriteLine("Enter as many items, one by one, in the alloted time. Type 'done' if finished.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write(prompt);
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine();

        int duration = Duration(); 

        string input;

        List<string> responses = new List<string>();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration & ((input = Console.ReadLine()) != "done"))
        {
            
            Console.Write(GetRandomQuestion());
            responses.Add(input);
            
        }
        
        DisplayEndingMessage();
    }
}
    