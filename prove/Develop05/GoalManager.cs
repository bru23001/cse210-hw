/*
The goal manager class will need behaviors related to the menu system such as the following:

    1. Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    2. DisplayPlayerInfo - Displays the players current score.
    3. ListGoalNames - Lists the names of each of the goals.
    4. ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
    5. CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    6. RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    7. SaveGoals - Saves the list of goals to a file.
    8. LoadGoals - Loads the list of goals from a file.
    
In addition to the methods described here, you might find it helpful to create other private methods to help perform steps of these goals.

ATTRIBUTES:
In addition to the goal classes, the GoalManager class will need to keep track of the list of goals as well as the players score.
    
    1) _goals : List<Goal>
    2) _score : int
CONSTRUCTORS:
    GoalManager() - Initializes and empty list of goals and sets the player's score to be 0.

*/

using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
       int userOption = 0;
        while (userOption != 8)
        {
            Console.WriteLine("1. Display player info");
            Console.WriteLine("2. List goal names");
            Console.WriteLine("3. List goal details");
            Console.WriteLine("4. Create goal");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Save goals");
            Console.WriteLine("7. Load goals");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            userOption = int.Parse(Console.ReadLine());

        
            if (userOption == 1)
            {
                GoalManager manager = new GoalManager();
                manager.DisplayPlayerInfo();  
            }
            
            else if (userOption == 2)
            {
                GoalManager manager = new GoalManager();
                manager.ListGoalNames();  
            }
            
            else if (userOption == 3)
            {
                GoalManager manager = new GoalManager();
                manager.ListGoalDetails();    
            }
            
            else if (userOption == 4)
            {
                GoalManager manager = new GoalManager();
                manager.CreateGoal();    
            }
            else if (userOption == 5)
            {
                GoalManager manager = new GoalManager();
                manager.RecordEvent();    
            }        
            
            else if (userOption == 6)
            {
                GoalManager manager = new GoalManager();
                manager.SaveGoals();    
            }        
            
            else if (userOption == 7)
            {
                GoalManager manager = new GoalManager();
                manager.LoadGoals();    
            }
        
            else if (userOption == 8)
            {
                    Console.WriteLine("Exiting the program...");
            }    
            else 
            {   
                    Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (Goal name in _goals)
        {
            Console.WriteLine(name);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        // Ask user for goal details and add to list.
    }

    public void RecordEvent()
    {
        // Ask user which goal they completed and record event.
    }

    public void SaveGoals()
    {
        // Save goals to file.
    }

    public void LoadGoals()
    {
        // Load goals from file.
    }
}
