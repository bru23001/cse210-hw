/*
Consider an app that provides three different kinds of mindfulness opportunities.
It could give some guidance and structure to users in the following activities:

    ○ Breathing Activity - Help the user pace their breathing to have a session
      of deep breathing for a certain amount of time. They might find more peace 
      and less stress through the exercise.
    ○ Reflection Activity - Guide the user to think deeply, by having them consider
      a certain experience when they were successful or demonstrated strength. 
      Then, prompt them with questions to reflect more deeply about details of 
      this experience. They might discover more depth than they previously 
      realized.
    ○ Listing Activity - Guide the user to think broadly, by helping them list 
      as many things as they can in a certain area of strength or positivity. 
      They might discover more breadth than they previously realized.
    
The application could give additional help to the user keeping track of the 
time or frequency they spend in these activities and give them gentle prompts 
and reminders.

The user interface of a program like this could be anything from a Website 
or Mobile App to one that runs on a Smart Watch and it could be done in many 
different kinds of colors, shapes, and styles. Learning to write a program to 
solve the real-world problem is the most critical part, so this assignment will
focus on that, rather than creating a flashy interface.

a. Functional requirements

    1. Have a menu system to allow the user to choose an activity.

    2. Each activity should start with a common starting message that provides 
       the name of the activity, a description, and asks for and sets the duration
       of the activity in seconds. Then, it should tell the user to prepare to 
       begin and pause for several seconds.

    3. Each activity should end with a common ending message that tells the user
       they have done a good job, and pause and then tell them the activity they
       have completed and the length of time and pauses for several seconds 
       before finishing.

    4. Whenever the application pauses it should show some kind of animation 
       to the user, such as a spinner, a countdown timer, or periods being 
       displayed to the screen.

    5. The interface for the program should remain generally true to the one 
       shown in the video demo.

    6. Provide activities for reflection, breathing, and enumeration, as 
       described in each class.

b. Design Requirements
		
    1. Use inheritance by having a separate class for each kind of activity 
       with a base class to contain any shared attributes or behaviors.

    2. Avoid duplicating code in classes where it could instead be placed in a 
       base class.

    3. Follow the principles of encapsulation and abstraction by having private
       member variables and putting related items in the same class.

c. Showing Creativity and Exceeding Requirements
	
	Here are some ideas you might consider:
	
		· Adding another kind of activity.
		· Keeping a log of how many times activities were performed.
		· Make sure no random prompts/questions are selected until they have 
          all been used at least once in that session.
		· Saving and loading a log file.
		· Adding more meaningful animations for the breathing (such as text 
          that grows out quickly at first and then slows as they near the end 
          of the breath).
		· Anything else you can think of!
    
    Report on what you have done to exceed requirements by adding a description
    of it in a comment in the Program.cs file.

Menu Options:
1. Start breathing activity
2. Start reflecting activity
3. Start listing activity
4. Quit
Select a choice from the menu:
*/

using System;
using System.Linq.Expressions;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool brexit = true;
        
        while (brexit)
        {
            int userOption = GetMenu();
            LoopMenu(userOption);
            Console.WriteLine();
            Console.WriteLine("Do you want to try another activity? Y/N: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "n")
            {
                brexit = false;
            }

            Console.Clear();
        }
    }
        
    static void LoopMenu(int userOption)
    {
        if (userOption == 1)
        {
            BreathingActivity activity1 = new BreathingActivity("breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            activity1.DisplayStartingMessage();
            activity1.Run();

        }
        else if (userOption == 2)
        {
            ReflectingActivity activity2 = new ReflectingActivity("reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            activity2.DisplayStartingMessage();
            activity2.Run();
        }
        else if (userOption == 3)
        {
            ListingActivity activity3 = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            activity3.DisplayStartingMessage();
            activity3.Run();
        }
        else if (userOption == 4)
        {

        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }

    }    
    static int GetMenu()
    {
        Console.WriteLine("   ----MENU OPTIONS----");
        Console.WriteLine();
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");

        int userOption = int.Parse(Console.ReadLine());

        return userOption;
    }
}