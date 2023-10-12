/*
Gamification is the idea of turning something into a game. It could include a number of different
concepts, but often involves getting badges or awards, as you "level up" with more points. Consider 
a program that keeps track of various kinds of goals that people have, which are goals in their real 
life, such as studying the scriptures each day, finishing a project, or even stopping a bad habit. 
This program could be set up to keep track of your progress on these goals and offer points, awards, 
or other celebrations to keep you encouraged to keep working. A program like this could be more serious,
and just keep track of goal progress, or it could be as funny and personal as you would want (for 
example, a level 13 Ninja Unicorn). The idea is to engage the part of our brain that loves seeing these
"wins" and accomplishments as we work on our goals.

1) Functional requirements:
            
    1- Provide for simple goals that can be marked complete and the user gains some value.For example, if you run 
    a marathon you get 1000 points.
    2- Provide for eternal goals that are never complete, but each time the user records them, they gain some 
    value.For example, every time you read your scriptures you get 100 points.
    3- Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time 
    the user records this goal they gain some value, but when they achieve the desired amount, they get an extra 
    bonus.For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, 
    and then a bonus of 500 points on the 10th time.
    4- Display the user's score.
    5- Allow the user to create new goals of any type.
    6- Allow the user to record an event (meaning they have accomplished a goal and should receive points).
    7- Show a list of the goals. This list should show indicate whether the goal has been completed or not (for 
    example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed
        (for example Completed 2/5 times).
    8- Allow the user's goals and their current score to be saved and loaded.
    
2) Design Requirements:
   
    1- Use inheritance by having a separate class for each kind of activity with a base class to contain any 
    shared attributes or behaviors.
    2- Use polymorphism by having derived classes override base class methods where appropriate.
    3- Follow the principles of encapsulation and abstraction by having private member variables and putting 
    related items in the same class.

3) Showing Creativity and Exceeding Requirements
		
    Meeting the core requirements makes your program eligible to receive a 93%. To receive 100% on the assignment, 
    you need to show creativity and exceed these requirements.
    
    Here are some ideas you might consider:
    
        § Add your own ideas for gamification. This could include leveling up, earning certain bonuses, or other 
        "fun" aspects to the quest.
        § Add additional kinds of goals, such as the ability to make progress towards a large goal (such as getting
        value for working towards running a marathon), or "negative goals" where they lose points for bad habits.
        § There are lots of ways to show creativity in this assignment. Pick anything that sounds fun to you!
        
    Report on what you have done to exceed requirements by adding a description of it in a comment in the Program.cs file.

        

	

*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("1. Display player info");
        Console.WriteLine("2. List goal names");
        Console.WriteLine("3. List goal details");
        Console.WriteLine("4. Create goal");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Save goals");
        Console.WriteLine("7. Load goals");
        Console.WriteLine("8. Exit");
    }

    public static void HandleUserInput(GoalManager manager)
    {
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                manager.DisplayPlayerInfo();
                break;
            case 2:
                manager.ListGoalNames();
                break;
            case 3:
                manager.ListGoalDetails();
                break;
            case 4:
                manager.CreateGoal();
                break;
            case 5:
                manager.RecordEvent();
                break;
            case 6:
                manager.SaveGoals();
                break;
            case 7:
                manager.LoadGoals();
                break;
            case 8:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}



