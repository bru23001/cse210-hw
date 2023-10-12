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

    public bool Name { get; internal set; }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }




       // public abstract void RecordEvent(Goal goal)
        //{
       //     return Goal.IsComplete();
       // }
    


    public abstract bool IsComplete()
    {
        _isComplete = true;
        return _points;
    }


    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName}: {_description}";
    }
    public abstract string GetStringRepresentation();
}

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
         _isComplete = true;
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }
}

// Similar changes would be made to the EternalGoal and ChecklistGoal classes.
/*
public class Goal
{
    public int Points { get; set; }
    public bool IsComplete { get; set; }

    public virtual int Complete()
    {
        IsComplete = true;
        return Points;
    }
}

public class ChecklistGoal : Goal
{
    public int CompletionCount { get; set; }
    public int BonusPoints { get; set; }

    public override int Complete()
    {
        CompletionCount++;
        if (CompletionCount % 5 == 0) // Assuming bonus is awarded every 5 completions
        {
            return base.Complete() + BonusPoints;
        }
        return base.Complete();
    }
}

public class GoalTracker
{
    public int RecordEvent(Goal goal)
    {
        return goal.Complete();
    }
}


*/