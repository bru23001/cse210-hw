// RESPONSABILITY: Supplies random prompts whenever needed.

// ATRIBUTE: the prompt generator should store a list of potential prompts 
// that it can select from randomly when needed.
// _prompts : List<string>

// METHOD: 
// GetRandomPrompt() : string

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// PromptGenerator class: Supplies random prompts so the user can just reply 
// to these prompts in form of entry.
class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
         _prompts = new List<string>();
         _prompts.Add("What are you grateful for today?");
         _prompts.Add("What is something you learned today?");
         _prompts.Add("What is something you want to achieve tomorrow?");
         _prompts.Add("How are you feeling right now?");
         _prompts.Add("What is your favorite memory from this day?");
    }

    // Returns a random prompt from the _prompts list using Random.Next
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
   
    
}