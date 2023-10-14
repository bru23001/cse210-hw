/*	
One of the core pieces of functionality for each of these classes is that each goal needs to provide a way
to record the event (in other words, mark that is has been accomplished another time). In addition, each 
one needs to provide a check to see if it is complete. Because these methods exist for all classes, they 
should be defined in the base class. However, because they all have different functionality, they should 
be overridden in the derived classes:

    1. RecordEvent - This method should do whatever is necessary for each specific kind of goal, such as 
    marking a simple goal complete and adding to the number of times a checklist goal has been completed. 
    It should return the point value associated with recording the event (keep in mind that it may contain 
    a bonus in some cases if a checklist goal was just finished, for example).
    
    2. IsComplete - This method should return true if the goal is completed. The way you determine if a goal
    is complete is different for each type of goal.
    
In addition to recording the event and checking if it is complete. Each goal will need to be shown in a list 
(with the checkbox etc), and also each one will need a string representation that can be saved to a text file. 
These should also be declared in the base class and overridden in the derived classes as needed:

        1) GetDetailsString - This method should return the details of a goal that could be shown in a list. 
        It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal 
        class, it should be overridden to shown the number of times the goal has been accomplished so far.
        2) GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
        easy to save to a file, and then load later.

BEHAVIORS: 
    1) RecordEvent() : void (Abstract)
    2) IsComplete() : bool (Abstract)
    3) GetDetailsString() : string
    4) GetStringRepresentation() : string (Abstract)

ATTRIBUTES:
    1) _shortName : string
    2) _description : string
    3) _points : int

CONSTRUCTORS:
	Goal(name : string, description : string, points : int)






*/


public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }




    public abstract void RecordEvent();
    /*{
        
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

    }*/

       
       
       
    
    


    public abstract bool IsComplete();
    


    public virtual string GetDetailsString()
    {
        string detailsString = $" [ ] {_shortName} - {_description}";

        return detailsString;
    }
    public abstract string GetStringRepresentation();
}


