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
        List<Goal> _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
       int userOption = 0;
        while (userOption != 6)
        {
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals ");
            Console.WriteLine("3. Save goals to a file");
            Console.WriteLine("4. Load Goals from a file");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            userOption = int.Parse(Console.ReadLine());

        
            if (userOption == 1)
            {
                CreateGoal();    
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

    private void CreateGoal()
    {
        
        Console.WriteLine("These are the goals you can choose from: ");
        Console.WriteLine("1. Simple goal: ");
        Console.WriteLine("2. Eternal goal: ");
        Console.WriteLine("3. Checklist goal: ");
        Console.WriteLine("4. Return to Main Menu: ");
        Console.Write("What option do you choose? ");
        goalDetails=

        int userOption = int.Parse(Console.ReadLine());
        while (userOption != 4)
        {
            if (userOption == 1 || userOption == 2)
            {
                Console.Write("What tipe of goal you want to create? ");
                int subMenuGoal = int.Parse(Console.ReadLine());
                Console.Write("What's the name of your goal? ");
                string subMenuName = Console.ReadLine();
                Console.Write("What is a short description of the goal? ");
                string subMenuDescription = Console.ReadLine();
                Console.Write("How many points do I want associated to this goal? ");
                int subMenuPoints = int.Parse(Console.ReadLine());
                _goals.Add(subMenuGoal,subMenuName,subMenuDescription,subMenuPoints);
            }
        }

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
