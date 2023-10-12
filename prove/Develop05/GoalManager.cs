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
        while (userOption != 4)
        {
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            userOption = Convert.ToInt32(Console.ReadLine());

            if (userOption == 1)
            {
                Console.WriteLine("You selected Option 1.");
                    // Add code for Option 1.
            }
            else if (userOption == 2)
            {
                Console.WriteLine("You selected Option 2.");
                    // Add code for Option 2.
            }
            else if (userOption == 3)
            {
                    Console.WriteLine("Exiting the program...");
            }
            else if (userOption == 4)
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
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.Name);
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
