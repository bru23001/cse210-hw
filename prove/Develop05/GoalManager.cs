
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
using System.Linq;
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
            Console.WriteLine(goal.Name);
        }
    }


    public void CreateGoal()
    {
        int goalType = 0;
       
        while (goalType != 4)
        {
            Console.WriteLine("These are the goals you can choose from: ");
            Console.WriteLine("1. Simple goal: ");
            Console.WriteLine("2. Eternal goal: ");
            Console.WriteLine("3. Checklist goal: ");
            Console.WriteLine("4. Return to Main Menu: ");
            Console.Write("What option do you choose? ");
            goalType = int.Parse(Console.ReadLine());

            if (goalType == 4)
            {
                return;
            }
        

            Console.Write("Enter the name of the goal: ");
            string name = Console.ReadLine();

            Console.Write("Enter the description of the goal: ");
            string description = Console.ReadLine();

            Console.Write("Enter the points of the goal: ");
            int points = int.Parse(Console.ReadLine());

            Goal goal;
            
            if (goalType == 1)
            {
                goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
                
            }

            else if (goalType == 2)
            {
                goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }

            else if (goalType == 3)
            {
               
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points,target,bonus);
                _goals.Add(goal);
            }

            else
            {
                Console.WriteLine("Invalid option");
                return;
            }  
          
        }

    }


    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplished? ");
        int goalType = int.Parse(Console.ReadLine());


        foreach (Goal goal in _goals)
        {
            if (goalType >= 0 && goalType < _goals.Count)
            {
                goal.RecordEvent();
                Console.WriteLine("Event recorded");
                return;
            }

        else
            {
                Console.WriteLine("Invalid option");
            }
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
            int goalType = int.Parse(parts[0]);
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int bonus = int.Parse(parts[5]);
            bool isComplete = bool.Parse(parts[6]);

            Goal goal;
            if (goalType == 1)
            {
                goal = new SimpleGoal(name,description,points);
                _goals.Add(goal);
            }
            else if (goalType == 2)
            {
                goal = new EternalGoal(name,description,points);
                _goals.Add(goal);
            } 

            else if (goalType == 3)
            {
                goal = new ChecklistGoal(name,description,points,target,bonus);
                _goals.Add(goal);
            }


            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", goalType, name, description,points, target, bonus, isComplete);

        }


        
    }
}
