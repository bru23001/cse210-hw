
/*The goal manager class will need behaviors related to the menu system such as the following:

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
using System.ComponentModel;
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
        while (userOption != 6)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals ");
            Console.WriteLine("3. Save goals to a file");
            Console.WriteLine("4. Load Goals from a file");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            userOption = int.Parse(Console.ReadLine());
            Console.Clear();
            DisplayPlayerInfo();

        
            if (userOption == 1)
            {
                CreateGoal();    
            }
            
            else if (userOption == 2)
        {
                ListGoalDetails();
            
/*                foreach(Goal goal in _goals)
                {
                    string[] parts = goal.Split(",");
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int target = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    bool isComplete = bool.Parse(parts[5]);
        }
*/                
                //ListGoalNames();  
            }
            
            else if (userOption == 3)
            {
                SaveGoals();
            }
            
            else if (userOption == 4)
            {
                LoadGoals(); 
            }
            else if (userOption == 5)
            {
                RecordEvent();    
            }        
            
            
        }
    }

    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.name);
        }
    }


    public void CreateGoal()
    {
        
        Console.WriteLine("These are the goals you can choose from: ");
        Console.WriteLine("1. Simple goal: ");
        Console.WriteLine("2. Eternal goal: ");
        Console.WriteLine("3. Checklist goal: ");
        Console.WriteLine("4. Return to Main Menu: ");
        Console.Write("What option do you choose? ");
        int goalType = int.Parse(Console.ReadLine());

        while (goalType != 4)
        {
            Goal goal = null;
            if (goalType == 1)
            {
                Console.Write("What's the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of the goal? ");
                string description = Console.ReadLine();
                Console.Write("How many points do I want associated to this goal? ");
                int points = int.Parse(Console.ReadLine());

                goal = new SimpleGoal(name, description, points);
            }

            if (goalType == 2)
            {
                Console.Write("What's the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of the goal? ");
                string description = Console.ReadLine();
                Console.Write("How many points do I want associated to this goal? ");
                int points = int.Parse(Console.ReadLine());

                goal = new EternalGoal(name, description, points);
            }

            if (goalType == 3)
            {
                Console.Write("What's the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of the goal? ");
                string description = Console.ReadLine();
                Console.Write("How many points do I want associated to this goal? ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points,target,bonus);
            }

            else
            {
                Console.WriteLine("Invalid option");
                return;
            }

            _goals.Add(goal);
        }

    }


    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplished? ");
        int goalType = int.Parse(Console.ReadLine());

        if (goalType >= 0 && goalType < _goals.Count)
        {
            Console.WriteLine("Event recorded");
        }

        else
        {
            Console.WriteLine("Invalid option");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved");
    }

    public void LoadGoals()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            int target = int.Parse(parts[3]);
            int bonus = int.Parse(parts[4]);
            bool isComplete = bool.Parse(parts[5]);
        }


        
    }
}
